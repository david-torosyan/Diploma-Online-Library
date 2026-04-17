using Library.DAL.Models;

namespace Library.DAL.IRepositories;

public interface IChatMessageRepository
{
    Task<List<ChatMessage>> GetConversationMessagesAsync(Guid conversationId, int pageSize, long? beforeMessageId = null);
    Task<int> GetUnreadCountForConversationAsync(Guid conversationId, string userId);
    Task AddAsync(ChatMessage message);
    Task<long> GetUnreadCountAsync(string userId);
    Task SaveChangesAsync();
}
