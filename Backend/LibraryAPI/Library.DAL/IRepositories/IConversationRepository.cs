using Library.DAL.Models;

namespace Library.DAL.IRepositories;

public interface IConversationRepository
{
    Task<Conversation?> GetByIdWithParticipantsAsync(Guid conversationId);
    Task<Conversation?> GetByIdWithDetailsAsync(Guid conversationId);
    Task<List<Conversation>> GetUserConversationsAsync(string userId, int take = 50);
    Task<Conversation?> GetPrivateConversationAsync(string firstUserId, string secondUserId);
    Task<bool> IsParticipantAsync(Guid conversationId, string userId);
    Task<ConversationParticipant?> GetParticipantAsync(Guid conversationId, string userId);
    Task AddAsync(Conversation conversation);
    Task AddParticipantAsync(ConversationParticipant participant);
    Task SaveChangesAsync();
}
