using LibraryAPI.Models;

namespace LibraryAPI.Services.IServices;

public interface IChatService
{
    Task<List<ConversationSummaryDto>> GetMyConversationsAsync();
    Task<ConversationSummaryDto> StartPrivateConversationAsync(string recipientUserId);
    Task<ConversationSummaryDto> CreateGroupConversationAsync(CreateGroupConversationRequestDto request);
    Task<List<ChatMessageDto>> GetMessagesAsync(Guid conversationId, int pageSize = 50, long? beforeMessageId = null);
    Task<ChatMessageDto> SendMessageAsync(Guid conversationId, string content);
    Task MarkConversationAsReadAsync(Guid conversationId);
    Task AddParticipantAsync(Guid conversationId, string participantUserId);
    Task<long> GetUnreadCountAsync();
    Task<bool> CanAccessConversationAsync(Guid conversationId);
    Task<List<ChatUserDto>> GetUsersAsync();
    Task<ChatUserDto> GetCurrentUserInfoAsync();
}
