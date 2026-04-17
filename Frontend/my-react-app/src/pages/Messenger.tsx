import { useEffect, useMemo, useRef, useState } from "react";
import { useTranslation } from "react-i18next";
import { useLocation } from "react-router-dom";
import { getAuthToken, getCurrentUserId } from "../utils/auth";
import {
  createChatHubConnection,
  createGroupConversation,
  getChatUsers,
  getConversations,
  getMessages,
  markConversationRead,
  sendMessage,
  startPrivateConversation,
} from "../services/chatService";
import type { ChatMessage, ChatUser, ConversationSummary, TypingEvent } from "../types/chat";
import type { HubConnection } from "@microsoft/signalr";
import { improveText, getQuickReplies } from "../services/aiWritingService.ts";

const MAX_MESSAGE_LENGTH = 2000;

type MessengerLocationState = {
  recipientUserId?: string;
  conversationId?: string;
};

const Messenger = () => {
  const { t } = useTranslation();
  const [users, setUsers] = useState<ChatUser[]>([]);
  const [conversations, setConversations] = useState<ConversationSummary[]>([]);
  const [activeConversationId, setActiveConversationId] = useState<string | null>(null);
  const [messages, setMessages] = useState<ChatMessage[]>([]);
  const [messageText, setMessageText] = useState("");
  const [selectedUserId, setSelectedUserId] = useState("");
  const [isPrivatePickerOpen, setIsPrivatePickerOpen] = useState(false);
  const [groupName, setGroupName] = useState("");
  const [groupParticipantIds, setGroupParticipantIds] = useState<string[]>([]);
  const [isGroupCreatorOpen, setIsGroupCreatorOpen] = useState(false);
  const [isParticipantsPanelOpen, setIsParticipantsPanelOpen] = useState(false);
  const [typingByConversation, setTypingByConversation] = useState<Record<string, Record<string, string>>>({});
  const [loading, setLoading] = useState(true);
  const [sending, setSending] = useState(false);
  const [error, setError] = useState<string | null>(null);
  const [isHubReady, setIsHubReady] = useState(false);
  const [quickReplies, setQuickReplies] = useState<string[]>([]);
  const [loadingReplies, setLoadingReplies] = useState(false);
  const [aiImproving, setAiImproving] = useState(false);

  const hubRef = useRef<HubConnection | null>(null);
  const messageEndRef = useRef<HTMLDivElement | null>(null);
  const activeConversationIdRef = useRef<string | null>(null);
  const privatePickerRef = useRef<HTMLDivElement | null>(null);
  const typingTimeoutsRef = useRef<Record<string, Record<string, ReturnType<typeof setTimeout>>>>({});
  const didApplyRouteStateRef = useRef(false);
  const location = useLocation();

  const token = getAuthToken();
  const currentUserId = getCurrentUserId();

  const activeConversation = useMemo(
    () => conversations.find((c) => c.id === activeConversationId) ?? null,
    [conversations, activeConversationId]
  );

  const selectedPrivateUser = useMemo(
    () => users.find((user) => user.id === selectedUserId) ?? null,
    [users, selectedUserId]
  );

  const sortedUsersForPrivate = useMemo(
    () =>
      [...users].sort(
        (a, b) => Number(b.isOnline) - Number(a.isOnline) || a.displayName.localeCompare(b.displayName)
      ),
    [users]
  );

  const locationState = (location.state ?? null) as MessengerLocationState | null;

  useEffect(() => {
    activeConversationIdRef.current = activeConversationId;
  }, [activeConversationId]);

  useEffect(() => {
    setIsParticipantsPanelOpen(false);
  }, [activeConversationId]);

  useEffect(() => {
    if (!isPrivatePickerOpen) {
      return;
    }

    const handleOutsideClick = (event: MouseEvent) => {
      if (!privatePickerRef.current?.contains(event.target as Node)) {
        setIsPrivatePickerOpen(false);
      }
    };

    document.addEventListener("mousedown", handleOutsideClick);
    return () => {
      document.removeEventListener("mousedown", handleOutsideClick);
    };
  }, [isPrivatePickerOpen]);

  const getConversationInitials = (title: string) => {
    const parts = title
      .split(" ")
      .map((part) => part.trim())
      .filter(Boolean)
      .slice(0, 2);

    if (parts.length === 0) {
      return "CH";
    }

    return parts.map((part) => part[0]?.toUpperCase() ?? "").join("");
  };

  const getUserInitials = (displayName: string) => {
    const parts = displayName
      .split(" ")
      .map((part) => part.trim())
      .filter(Boolean)
      .slice(0, 2);

    if (parts.length === 0) {
      return "U";
    }

    return parts.map((part) => part[0]?.toUpperCase() ?? "").join("");
  };

  const getConversationPresence = (conversation: ConversationSummary) => {
    const participants = conversation.participants;

    if (!conversation.isGroup) {
      const peer = participants.find((participant) => participant.id !== currentUserId) ?? participants[0];
      const isOnline = peer?.isOnline ?? false;

      return {
        label: isOnline ? t("online", "Online") : t("offline", "Offline"),
        className: isOnline ? "is-online" : "is-offline",
      };
    }

    const onlineCount = participants.filter((participant) => participant.isOnline).length;

    return {
      label: `${onlineCount}/${participants.length} ${t("online", "Online")}`,
      className: onlineCount > 0 ? "is-online" : "is-offline",
    };
  };

  const buildDefaultGroupName = (participantIds: string[]) => {
    const initials = participantIds
      .map((participantId) => users.find((user) => user.id === participantId)?.displayName?.trim())
      .filter((displayName): displayName is string => Boolean(displayName))
      .map((displayName) => {
        const [firstWord] = displayName.split(/\s+/);
        return firstWord?.[0]?.toUpperCase() ?? "";
      })
      .join("");

    return initials || t("groupFallbackName", "Group");
  };

  const activeTypingUsers = useMemo(() => {
    if (!activeConversationId) return [];
    return Object.values(typingByConversation[activeConversationId] ?? {});
  }, [activeConversationId, typingByConversation]);

  const clearConversationUnreadInState = (conversationId: string) => {
    setConversations((prev) => {
      const next = prev.map((conversation) =>
        conversation.id === conversationId ? { ...conversation, unreadCount: 0 } : conversation
      );

      const unread = next.reduce((sum, c) => sum + c.unreadCount, 0);
      window.dispatchEvent(new CustomEvent<number>("chat-unread-count-changed", { detail: unread }));
      return next;
    });
  };

  useEffect(() => {
    if (!token) {
      setError(t("messengerSignInToOpen", "Please sign in to open Messenger."));
      setLoading(false);
      return;
    }

    let isMounted = true;

    const loadInitialData = async () => {
      try {
        setLoading(true);
        setError(null);

        const [userList, conversationList] = await Promise.all([
          getChatUsers(token),
          getConversations(token),
        ]);

        if (!isMounted) return;

        setUsers(userList);
        const orderedConversations = [...conversationList].sort(
          (a, b) => +new Date(b.lastMessageAtUtc) - +new Date(a.lastMessageAtUtc)
        );
        setConversations(orderedConversations);

        const unread = orderedConversations.reduce((sum, c) => sum + c.unreadCount, 0);
        window.dispatchEvent(new CustomEvent<number>("chat-unread-count-changed", { detail: unread }));

        if (!didApplyRouteStateRef.current && locationState) {
          didApplyRouteStateRef.current = true;

          if (locationState.recipientUserId) {
            const conversation = await startPrivateConversation(token, locationState.recipientUserId);

            setConversations((prev) => {
              const without = prev.filter((item) => item.id !== conversation.id);
              return [conversation, ...without];
            });

            await handleSelectConversation(conversation.id, true, token);
            return;
          }

          if (locationState.conversationId) {
            await handleSelectConversation(locationState.conversationId, true, token);
            return;
          }
        }

        if (orderedConversations.length > 0) {
          await handleSelectConversation(orderedConversations[0].id, true, token);
        }
      } catch {
        if (isMounted) {
          setError(t("messengerLoadFailed", "Failed to load chats."));
        }
      } finally {
        if (isMounted) {
          setLoading(false);
        }
      }
    };

    loadInitialData();

    return () => {
      isMounted = false;
    };
  }, [token, locationState]);

  useEffect(() => {
    if (!token) return;

    const hub = createChatHubConnection(token);
    hubRef.current = hub;

    hub.on("MessageReceived", (incoming: ChatMessage) => {
      const isActiveConversation = activeConversationIdRef.current === incoming.conversationId;

      setConversations((prev) => {
        const next = prev.map((conversation) => {
          if (conversation.id !== incoming.conversationId) {
            return conversation;
          }

          const shouldCountUnread = incoming.senderUserId !== currentUserId && !isActiveConversation;

          return {
            ...conversation,
            lastMessage: incoming,
            lastMessageAtUtc: incoming.sentAtUtc,
            unreadCount: shouldCountUnread ? conversation.unreadCount + 1 : 0,
          };
        });

        const sorted = [...next].sort((a, b) => +new Date(b.lastMessageAtUtc) - +new Date(a.lastMessageAtUtc));
        const unread = sorted.reduce((sum, c) => sum + c.unreadCount, 0);
        window.dispatchEvent(new CustomEvent<number>("chat-unread-count-changed", { detail: unread }));
        return sorted;
      });

      if (isActiveConversation) {
        setMessages((prev) => {
          if (prev.some((m) => m.id === incoming.id)) {
            return prev;
          }

          return [...prev, incoming];
        });

        if (incoming.senderUserId !== currentUserId) {
          markConversationRead(token, incoming.conversationId).catch(() => undefined);
        }
      }
    });

    hub.on("Typing", (event: TypingEvent) => {
      if (event.userId === currentUserId) {
        return;
      }

      const timeoutsByConversation = typingTimeoutsRef.current[event.conversationId] ?? {};
      const existingTimeout = timeoutsByConversation[event.userId];
      if (existingTimeout) {
        clearTimeout(existingTimeout);
      }

      setTypingByConversation((prev) => {
        const current = prev[event.conversationId] ?? {};

        let nextUsers = current;
        if (event.isTyping) {
          nextUsers = {
            ...current,
            [event.userId]: event.userName,
          };
        } else {
          const { [event.userId]: _removed, ...rest } = current;
          nextUsers = rest;
        }

        return {
          ...prev,
          [event.conversationId]: nextUsers,
        };
      });

      if (!event.isTyping) {
        if (typingTimeoutsRef.current[event.conversationId]) {
          delete typingTimeoutsRef.current[event.conversationId][event.userId];
        }
        return;
      }

      const timeoutId = setTimeout(() => {
        setTypingByConversation((prev) => {
          const current = prev[event.conversationId] ?? {};
          if (!current[event.userId]) {
            return prev;
          }

          const { [event.userId]: _removed, ...rest } = current;
          return {
            ...prev,
            [event.conversationId]: rest,
          };
        });

        if (typingTimeoutsRef.current[event.conversationId]) {
          delete typingTimeoutsRef.current[event.conversationId][event.userId];
        }
      }, 3500);

      typingTimeoutsRef.current[event.conversationId] = {
        ...timeoutsByConversation,
        [event.userId]: timeoutId,
      };
    });

    hub.on("UserOnline", (userId: string) => {
      setUsers((prev) => prev.map((u) => (u.id === userId ? { ...u, isOnline: true } : u)));
      setConversations((prev) =>
        prev.map((conversation) => ({
          ...conversation,
          participants: conversation.participants.map((participant) =>
            participant.id === userId ? { ...participant, isOnline: true } : participant
          ),
        }))
      );
    });

    hub.on("UserOffline", (userId: string) => {
      setUsers((prev) => prev.map((u) => (u.id === userId ? { ...u, isOnline: false } : u)));
      setConversations((prev) =>
        prev.map((conversation) => ({
          ...conversation,
          participants: conversation.participants.map((participant) =>
            participant.id === userId ? { ...participant, isOnline: false } : participant
          ),
        }))
      );
    });

    hub
      .start()
      .then(() => {
        setIsHubReady(true);
      })
      .catch(() => {
        setIsHubReady(false);
      });

    return () => {
      Object.values(typingTimeoutsRef.current).forEach((conversationTimeouts) => {
        Object.values(conversationTimeouts).forEach((timeoutId) => clearTimeout(timeoutId));
      });
      typingTimeoutsRef.current = {};

      hub.stop().catch(() => undefined);
      hubRef.current = null;
      setIsHubReady(false);
    };
  }, [token, currentUserId]);

  useEffect(() => {
    if (!isHubReady || !hubRef.current) {
      return;
    }

    const joinKnownConversations = async () => {
      for (const conversation of conversations) {
        try {
          await hubRef.current?.invoke("JoinConversation", conversation.id);
        } catch {
          // Conversation-level subscription failures should not break the page.
        }
      }
    };

    joinKnownConversations();
  }, [isHubReady, conversations]);

  useEffect(() => {
    messageEndRef.current?.scrollIntoView({ behavior: "smooth", block: "end" });
  }, [messages]);

  useEffect(() => {
    if (!token || !activeConversationId || messages.length === 0) {
      return;
    }

    const lastMessage = messages[messages.length - 1];
    if (!lastMessage || lastMessage.senderUserId === currentUserId) {
      return;
    }

    markConversationRead(token, activeConversationId)
      .then(() => {
        clearConversationUnreadInState(activeConversationId);
      })
      .catch(() => undefined);
  }, [token, activeConversationId, messages, currentUserId]);

  const handleSelectConversation = async (
    conversationId: string,
    shouldMarkRead = true,
    providedToken?: string
  ) => {
    const safeToken = providedToken ?? token;
    if (!safeToken) return;

    setActiveConversationId(conversationId);
    setTypingByConversation((prev) => ({ ...prev, [conversationId]: {} }));

    try {
      const list = await getMessages(safeToken, conversationId, 100);
      setMessages(list);

      if (shouldMarkRead) {
        await markConversationRead(safeToken, conversationId);
        clearConversationUnreadInState(conversationId);
      }

      if (hubRef.current && isHubReady) {
        await hubRef.current.invoke("JoinConversation", conversationId);
      }
    } catch {
      setError(t("messengerOpenConversationFailed", "Failed to open selected conversation."));
    }
  };

  const upsertConversation = (conversation: ConversationSummary) => {
    setConversations((prev) => {
      const without = prev.filter((item) => item.id !== conversation.id);
      const next = [conversation, ...without];
      const unread = next.reduce((sum, c) => sum + c.unreadCount, 0);
      window.dispatchEvent(new CustomEvent<number>("chat-unread-count-changed", { detail: unread }));
      return next;
    });
  };

  const handleStartPrivateConversation = async () => {
    if (!token || !selectedUserId) return;

    try {
      const conversation = await startPrivateConversation(token, selectedUserId);
      upsertConversation(conversation);
      await handleSelectConversation(conversation.id);
      setSelectedUserId("");
      setIsPrivatePickerOpen(false);

      if (hubRef.current && isHubReady) {
        await hubRef.current.invoke("JoinConversation", conversation.id);
      }
    } catch {
      setError(t("messengerStartPrivateFailed", "Could not start private conversation."));
    }
  };

  const handleCreateGroup = async () => {
    if (!token) return;

    const trimmedName = groupName.trim();
    if (groupParticipantIds.length === 0) {
      setError(t("messengerGroupParticipantsRequired", "Choose at least one participant."));
      return;
    }

    const finalGroupName = trimmedName || buildDefaultGroupName(groupParticipantIds);

    try {
      const conversation = await createGroupConversation(token, finalGroupName, groupParticipantIds);
      upsertConversation(conversation);
      await handleSelectConversation(conversation.id);
      setGroupName("");
      setGroupParticipantIds([]);
      setIsGroupCreatorOpen(false);

      if (hubRef.current && isHubReady) {
        await hubRef.current.invoke("JoinConversation", conversation.id);
      }
    } catch {
      setError(t("messengerCreateGroupFailed", "Could not create group chat."));
    }
  };

  const handleSendMessage = async () => {
    if (!token || !activeConversationId || sending) return;

    const trimmed = messageText.trim();
    if (!trimmed) return;

    if (trimmed.length > MAX_MESSAGE_LENGTH) {
      setError(
        t("messengerMessageTooLong", {
          defaultValue: "Message is too long. Max length is {{max}} characters.",
          max: MAX_MESSAGE_LENGTH,
        })
      );
      return;
    }

    try {
      setSending(true);
      setError(null);
      setMessageText("");

      if (hubRef.current && isHubReady) {
        await hubRef.current.invoke("SendMessage", activeConversationId, trimmed);
      } else {
        const message = await sendMessage(token, activeConversationId, trimmed);
        setMessages((prev) => [...prev, message]);
      }

      setTypingByConversation((prev) => ({ ...prev, [activeConversationId]: {} }));
    } catch {
      setError(t("messengerSendFailed", "Failed to send message."));
      setMessageText(trimmed);
    } finally {
      setSending(false);
    }
  };

  const handleTyping = async (nextValue: string) => {
    setMessageText(nextValue);

    if (!activeConversationId || !hubRef.current || !isHubReady) {
      return;
    }

    try {
      await hubRef.current.invoke("SendTyping", activeConversationId, nextValue.trim().length > 0);
    } catch {
      // SignalR typing failures are non-critical for message flow.
    }
  };

  const handleMessageKeyDown = (event: React.KeyboardEvent<HTMLTextAreaElement>) => {
    // Enter sends; Shift+Enter keeps multiline new lines.
    if (event.key === "Enter" && !event.shiftKey && !event.nativeEvent.isComposing) {
      event.preventDefault();
      void handleSendMessage();
    }
  };

  const handleLoadQuickReplies = async () => {
    if (!messages.length) return;

    setLoadingReplies(true);
    try {
      const lastMessage = messages[messages.length - 1];
      const context = `Last message: "${lastMessage.content}"`;
      const replies = await getQuickReplies(context, messageText, 5);
      setQuickReplies(replies);
    } catch (err) {
      console.error("Error loading quick replies:", err);
      setError(t("aiUnreachable", "AI Assistant is temporarily unavailable due to maintenance. Please try again later."));
      setQuickReplies([]);
    } finally {
      setLoadingReplies(false);
    }
  };

  const handleImproveMessage = async () => {
    if (!messageText.trim()) return;

    setAiImproving(true);
    try {
      const improved = await improveText(messageText, "chat message");
      setMessageText(improved);
      setQuickReplies([]);
    } catch (err) {
      console.error("Error improving message:", err);
      setError(t("aiUnreachable", "AI Assistant is temporarily unavailable due to maintenance. Please try again later."));
    } finally {
      setAiImproving(false);
    }
  };

  const handleSelectQuickReply = (reply: string) => {
    setMessageText(reply);
    setQuickReplies([]);
  };

  if (!token) {
    return (
      <section className="container py-4 messenger-page">
        <div className="messenger-empty-state">{t("messengerSignInToUse", "Please sign in to use Messenger.")}</div>
      </section>
    );
  }

  return (
    <section className="container py-3 py-lg-4 messenger-page">
      <div className="messenger-shell">
        <aside className="messenger-sidebar">
          <div className="messenger-sidebar-top">
            <h2 className="messenger-title">{t("messenger")}</h2>
            <p className="messenger-subtitle">{t("messengerSubtitle", "Start a private chat or open a group room.")}</p>
          </div>

          <div className="messenger-new-chat card-like">
            <div className="messenger-section-label">{t("messengerNewPrivateChat", "New private chat")}</div>
            <div className="messenger-private-chat-row">
              <div className="messenger-private-picker" ref={privatePickerRef}>
                <button
                  type="button"
                  className={`messenger-private-picker-trigger ${isPrivatePickerOpen ? "is-open" : ""}`}
                  onClick={() => setIsPrivatePickerOpen((prev) => !prev)}
                  aria-expanded={isPrivatePickerOpen}
                >
                  {selectedPrivateUser ? (
                    <span className="messenger-private-picker-trigger-selected">
                      <span className="messenger-private-picker-avatar" aria-hidden="true">
                        {getUserInitials(selectedPrivateUser.displayName)}
                      </span>
                      <span className="messenger-private-picker-trigger-text">{selectedPrivateUser.displayName}</span>
                    </span>
                  ) : (
                    <span className="messenger-private-picker-placeholder">{t("messengerChooseUser", "Choose user...")}</span>
                  )}
                  <span className="messenger-private-picker-chevron" aria-hidden="true">
                    {isPrivatePickerOpen ? "-" : "+"}
                  </span>
                </button>

                {isPrivatePickerOpen && (
                  <div className="messenger-private-picker-list" role="listbox" aria-label={t("users", "Users")}>
                    {sortedUsersForPrivate.map((user) => (
                      <button
                        key={user.id}
                        type="button"
                        role="option"
                        aria-selected={selectedUserId === user.id}
                        className={`messenger-private-picker-item ${selectedUserId === user.id ? "is-selected" : ""}`}
                        onClick={() => {
                          setSelectedUserId(user.id);
                          setIsPrivatePickerOpen(false);
                        }}
                      >
                        <span className="messenger-private-picker-avatar" aria-hidden="true">
                          {getUserInitials(user.displayName)}
                        </span>
                        <span className="messenger-private-picker-user-meta">
                          <span className="messenger-private-picker-user-name">{user.displayName}</span>
                          {user.email && <span className="messenger-private-picker-user-email">{user.email}</span>}
                        </span>
                        <span className={`messenger-private-picker-status ${user.isOnline ? "is-online" : "is-offline"}`}>
                          <span className="messenger-private-picker-status-dot" aria-hidden="true" />
                          {user.isOnline ? t("online", "Online") : t("offline", "Offline")}
                        </span>
                      </button>
                    ))}
                  </div>
                )}
              </div>
              <button className="btn btn-primary" onClick={handleStartPrivateConversation} disabled={!selectedUserId}>
                {t("start", "Start")}
              </button>
            </div>
          </div>

          <div className="messenger-new-chat card-like">
            <button
              className="btn btn-outline-primary w-100"
              onClick={() => setIsGroupCreatorOpen((prev) => !prev)}
              type="button"
            >
              {isGroupCreatorOpen
                ? t("messengerCloseGroupSetup", "Close group setup")
                : t("messengerCreateGroup", "Create group")}
            </button>

            {isGroupCreatorOpen && (
              <div className="messenger-group-builder mt-2">
                <div className="messenger-section-label">{t("messengerCreateGroup", "Create group")}</div>
                <input
                  className="form-control mb-2"
                  value={groupName}
                  onChange={(event) => setGroupName(event.target.value)}
                  placeholder={t("messengerGroupNamePlaceholder", "Group name (optional)")}
                />
                <div className="messenger-user-picker">
                  {users.map((user) => (
                    <label key={user.id} className="messenger-user-check">
                      <input
                        type="checkbox"
                        checked={groupParticipantIds.includes(user.id)}
                        onChange={(event) => {
                          setGroupParticipantIds((prev) =>
                            event.target.checked ? [...prev, user.id] : prev.filter((id) => id !== user.id)
                          );
                        }}
                      />
                      <span>{user.displayName}</span>
                    </label>
                  ))}
                </div>
                <button className="btn btn-outline-primary mt-2" onClick={handleCreateGroup}>
                  {t("messengerCreateGroup", "Create group")}
                </button>
              </div>
            )}
          </div>

          <section className="messenger-conversations-panel" aria-label={t("messengerRecentConversations", "Recent conversations")}>
            <div className="messenger-section-label messenger-conversations-heading">{t("messengerRecentConversations", "Recent conversations")}</div>
            <div className="messenger-conversation-list">
              {conversations.map((conversation) => {
                const isActive = activeConversationId === conversation.id;
                const hasUnread = conversation.unreadCount > 0;
                const preview = conversation.lastMessage?.content ?? t("messengerNoMessagesYet", "No messages yet");
                const presence = getConversationPresence(conversation);

                return (
                  <button
                    key={conversation.id}
                    type="button"
                    className={`messenger-conversation-item ${isActive ? "active" : ""} ${hasUnread ? "unread" : ""}`}
                    onClick={() => handleSelectConversation(conversation.id)}
                  >
                    <div className="messenger-conversation-row">
                      <div className="messenger-conversation-main">
                        <span className="messenger-conversation-avatar" aria-hidden="true">
                          {getConversationInitials(conversation.title)}
                        </span>
                        <div className="messenger-conversation-text">
                          <div className="messenger-conversation-name">{conversation.title}</div>
                          <div className={`messenger-conversation-presence ${presence.className}`}>
                            <span className="messenger-conversation-presence-dot" aria-hidden="true" />
                            {presence.label}
                          </div>
                          <div className="messenger-preview">{preview}</div>
                        </div>
                      </div>
                      <div className="messenger-conversation-meta">
                        <time className="messenger-time">{new Date(conversation.lastMessageAtUtc).toLocaleTimeString()}</time>
                        {hasUnread && <span className="messenger-unread-pill">{conversation.unreadCount}</span>}
                      </div>
                    </div>
                  </button>
                );
              })}
            </div>
          </section>
        </aside>

        <div className="messenger-chat-panel">
          {loading ? (
            <div className="messenger-empty-state">{t("messengerLoadingChats", "Loading chats...")}</div>
          ) : !activeConversation ? (
            <div className="messenger-empty-state">{t("messengerSelectConversation", "Select a conversation to start messaging.")}</div>
          ) : (
            <>
              <header className="messenger-chat-header">
                <div className="messenger-chat-header-main">
                  <h3>{activeConversation.title}</h3>
                  {activeConversation.isGroup ? (
                    <button
                      className="messenger-participants-trigger"
                      onClick={() => setIsParticipantsPanelOpen((prev) => !prev)}
                      type="button"
                      aria-expanded={isParticipantsPanelOpen}
                    >
                      <span className="messenger-participants-trigger-label">
                        {activeConversation.participants.length} {t("participants", "participants")}
                      </span>
                      <span className="messenger-participants-trigger-icon" aria-hidden="true">
                        {isParticipantsPanelOpen ? "-" : "+"}
                      </span>
                    </button>
                  ) : (
                    <p className="mb-0">{t("directChat", "Direct chat")}</p>
                  )}
                </div>
              </header>

              {activeConversation.isGroup && isParticipantsPanelOpen && (
                <section className="messenger-participants-panel" aria-label={t("participants", "Participants")}>
                  {activeConversation.participants.map((participant) => (
                    <div key={participant.id} className="messenger-participant-item">
                      <div className="messenger-participant-main">
                        <span className="messenger-participant-avatar" aria-hidden="true">
                          {getUserInitials(participant.displayName)}
                        </span>
                        <span className="messenger-participant-name">{participant.displayName}</span>
                      </div>
                      <span className={`messenger-participant-status ${participant.isOnline ? "is-online" : "is-offline"}`}>
                        <span className="messenger-participant-status-dot" aria-hidden="true" />
                        {participant.isOnline ? t("online", "Online") : t("offline", "Offline")}
                      </span>
                    </div>
                  ))}
                </section>
              )}

              <div className="messenger-messages" role="log" aria-live="polite">
                {messages.map((message) => {
                  const mine = message.senderUserId === currentUserId;

                  return (
                    <article key={message.id} className={`messenger-message ${mine ? "mine" : "other"}`}>
                      <div className="messenger-message-meta">
                        <span>{message.senderName}</span>
                        <time>{new Date(message.sentAtUtc).toLocaleString()}</time>
                      </div>
                      <div className="messenger-message-body">{message.content}</div>
                    </article>
                  );
                })}
                {activeTypingUsers.length > 0 && (
                  <div className="messenger-typing">
                    {t("messengerTypingStatus", {
                      defaultValue: "{{users}} typing...",
                      users: activeTypingUsers.join(", "),
                    })}
                  </div>
                )}
                <div ref={messageEndRef} />
              </div>

              {/* Quick Replies Section */}
              {quickReplies.length > 0 && (
                <div className="messenger-quick-replies p-2 bg-light border-top">
                  <p className="small text-muted mb-2">
                    ✨ {t("quickReplies", "Quick replies:")}
                  </p>
                  <div className="d-flex flex-wrap gap-2">
                    {quickReplies.map((reply, index) => (
                      <button
                        key={index}
                        type="button"
                        className="btn btn-sm btn-outline-primary rounded-pill"
                        onClick={() => handleSelectQuickReply(reply)}
                        title={reply}
                      >
                        {reply.length > 20 ? reply.substring(0, 20) + "..." : reply}
                      </button>
                    ))}
                  </div>
                </div>
              )}

              <footer className="messenger-input-row">
                <textarea
                  className="form-control"
                  value={messageText}
                  onChange={(event) => handleTyping(event.target.value)}
                  onKeyDown={handleMessageKeyDown}
                  maxLength={MAX_MESSAGE_LENGTH}
                  placeholder={t("messengerWriteMessage", "Write your message...")}
                  rows={2}
                />
                <div className="d-flex gap-2">
                  {messageText.trim().length > 0 && (
                    <>
                      <button
                        type="button"
                        className="btn btn-outline-secondary"
                        onClick={handleImproveMessage}
                        disabled={aiImproving}
                        title={t("aiImproveMessage", "Improve message with AI")}
                      >
                        ✨ {aiImproving ? t("improving", "Improving...") : t("aiImprove", "Improve")}
                      </button>
                      <button
                        type="button"
                        className="btn btn-outline-secondary"
                        onClick={handleLoadQuickReplies}
                        disabled={loadingReplies}
                        title={t("quickRepliesSuggest", "Get quick reply suggestions")}
                      >
                        💬 {loadingReplies ? t("loading", "Loading...") : t("quickReplies", "Replies")}
                      </button>
                    </>
                  )}
                  <button className="btn btn-primary" onClick={handleSendMessage} disabled={sending || !messageText.trim()}>
                    {t("send", "Send")}
                  </button>
                </div>
              </footer>
            </>
          )}

          {error && (
            <div 
              className={`messenger-error ${error.includes("temporarily unavailable") || error.includes("maintenance") ? "messenger-warning" : ""}`}
            >
              {error}
            </div>
          )}
        </div>
      </div>
    </section>
  );
};

export default Messenger;
