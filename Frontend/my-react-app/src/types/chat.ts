export interface ChatUser {
  id: string;
  displayName: string;
  email?: string;
  isOnline: boolean;
}

export interface ChatMessage {
  id: number;
  conversationId: string;
  senderUserId: string;
  senderName: string;
  content: string;
  sentAtUtc: string;
}

export interface ConversationSummary {
  id: string;
  isGroup: boolean;
  title: string;
  lastMessageAtUtc: string;
  unreadCount: number;
  participants: ChatUser[];
  lastMessage?: ChatMessage;
}

export interface TypingEvent {
  conversationId: string;
  userId: string;
  userName: string;
  isTyping: boolean;
}
