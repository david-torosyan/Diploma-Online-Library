import axios from "axios";
import * as signalR from "@microsoft/signalr";
import config from "../config/config.json";
import type { ChatMessage, ChatUser, ConversationSummary } from "../types/chat";

const api = axios.create({
  baseURL: config.baseUrl,
});

function authHeaders(token: string) {
  return {
    Authorization: `Bearer ${token}`,
  };
}

export async function getChatUsers(token: string): Promise<ChatUser[]> {
  const { data } = await api.get<ChatUser[]>("/api/chat/users", {
    headers: authHeaders(token),
  });

  return data;
}

export async function getConversations(token: string): Promise<ConversationSummary[]> {
  const { data } = await api.get<ConversationSummary[]>("/api/chat/conversations", {
    headers: authHeaders(token),
  });

  return data;
}

export async function startPrivateConversation(token: string, recipientUserId: string): Promise<ConversationSummary> {
  const { data } = await api.post<ConversationSummary>(
    "/api/chat/conversations/private",
    { recipientUserId },
    { headers: authHeaders(token) }
  );

  return data;
}

export async function createGroupConversation(
  token: string,
  name: string,
  participantUserIds: string[]
): Promise<ConversationSummary> {
  const { data } = await api.post<ConversationSummary>(
    "/api/chat/conversations/group",
    { name, participantUserIds },
    { headers: authHeaders(token) }
  );

  return data;
}

export async function getMessages(
  token: string,
  conversationId: string,
  pageSize = 50,
  beforeMessageId?: number
): Promise<ChatMessage[]> {
  const { data } = await api.get<ChatMessage[]>(`/api/chat/conversations/${conversationId}/messages`, {
    headers: authHeaders(token),
    params: {
      pageSize,
      beforeMessageId,
    },
  });

  return data;
}

export async function sendMessage(token: string, conversationId: string, content: string): Promise<ChatMessage> {
  const { data } = await api.post<ChatMessage>(
    `/api/chat/conversations/${conversationId}/messages`,
    { content },
    { headers: authHeaders(token) }
  );

  return data;
}

export async function markConversationRead(token: string, conversationId: string): Promise<void> {
  await api.post(
    `/api/chat/conversations/${conversationId}/read`,
    {},
    { headers: authHeaders(token) }
  );
}

export async function getUnreadCount(token: string): Promise<number> {
  const { data } = await api.get<number>("/api/chat/unread-count", {
    headers: authHeaders(token),
  });

  return data;
}

export function createChatHubConnection(token: string): signalR.HubConnection {
  return new signalR.HubConnectionBuilder()
    .withUrl(`${config.baseUrl}/hubs/chat`, {
      accessTokenFactory: () => token,
    })
    .withAutomaticReconnect()
    .build();
}
