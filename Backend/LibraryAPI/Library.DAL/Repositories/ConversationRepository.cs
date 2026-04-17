using Library.DAL.Data;
using Library.DAL.IRepositories;
using Library.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Repositories;

public class ConversationRepository : IConversationRepository
{
    private readonly ApplicationDbContext _context;

    public ConversationRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Conversation?> GetByIdWithParticipantsAsync(Guid conversationId)
    {
        return await _context.Conversations
            .Include(c => c.Participants)
                .ThenInclude(p => p.User)
            .FirstOrDefaultAsync(c => c.Id == conversationId);
    }

    public async Task<Conversation?> GetByIdWithDetailsAsync(Guid conversationId)
    {
        return await _context.Conversations
            .Include(c => c.Participants)
                .ThenInclude(p => p.User)
            .Include(c => c.Messages.OrderByDescending(m => m.SentAtUtc).Take(1))
                .ThenInclude(m => m.SenderUser)
            .FirstOrDefaultAsync(c => c.Id == conversationId);
    }

    public async Task<List<Conversation>> GetUserConversationsAsync(string userId, int take = 50)
    {
        return await _context.Conversations
            .AsNoTracking()
            .Include(c => c.Participants)
                .ThenInclude(p => p.User)
            .Include(c => c.Messages.OrderByDescending(m => m.SentAtUtc).Take(1))
                .ThenInclude(m => m.SenderUser)
            .Where(c => c.Participants.Any(p => p.ApplicationUserId == userId))
            .OrderByDescending(c => c.LastMessageAtUtc)
            .Take(take)
            .ToListAsync();
    }

    public async Task<Conversation?> GetPrivateConversationAsync(string firstUserId, string secondUserId)
    {
        return await _context.Conversations
            .Include(c => c.Participants)
            .FirstOrDefaultAsync(c =>
                !c.IsGroup &&
                c.Participants.Count == 2 &&
                c.Participants.Any(p => p.ApplicationUserId == firstUserId) &&
                c.Participants.Any(p => p.ApplicationUserId == secondUserId));
    }

    public async Task<bool> IsParticipantAsync(Guid conversationId, string userId)
    {
        return await _context.ConversationParticipants
            .AnyAsync(cp => cp.ConversationId == conversationId && cp.ApplicationUserId == userId);
    }

    public async Task<ConversationParticipant?> GetParticipantAsync(Guid conversationId, string userId)
    {
        return await _context.ConversationParticipants
            .FirstOrDefaultAsync(cp => cp.ConversationId == conversationId && cp.ApplicationUserId == userId);
    }

    public async Task AddAsync(Conversation conversation)
    {
        await _context.Conversations.AddAsync(conversation);
    }

    public async Task AddParticipantAsync(ConversationParticipant participant)
    {
        await _context.ConversationParticipants.AddAsync(participant);
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
