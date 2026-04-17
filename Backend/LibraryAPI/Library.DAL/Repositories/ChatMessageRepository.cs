using Library.DAL.Data;
using Library.DAL.IRepositories;
using Library.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Repositories;

public class ChatMessageRepository : IChatMessageRepository
{
    private readonly ApplicationDbContext _context;

    public ChatMessageRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<ChatMessage>> GetConversationMessagesAsync(Guid conversationId, int pageSize, long? beforeMessageId = null)
    {
        if (pageSize <= 0)
        {
            pageSize = 50;
        }

        pageSize = Math.Min(pageSize, 100);

        var query = _context.ChatMessages
            .AsNoTracking()
            .Include(m => m.SenderUser)
            .Where(m => m.ConversationId == conversationId);

        if (beforeMessageId.HasValue)
        {
            query = query.Where(m => m.Id < beforeMessageId.Value);
        }

        return await query
            .OrderByDescending(m => m.Id)
            .Take(pageSize)
            .OrderBy(m => m.Id)
            .ToListAsync();
    }

    public async Task AddAsync(ChatMessage message)
    {
        await _context.ChatMessages.AddAsync(message);
    }

    public async Task<int> GetUnreadCountForConversationAsync(Guid conversationId, string userId)
    {
        var participant = await _context.ConversationParticipants
            .AsNoTracking()
            .FirstOrDefaultAsync(p => p.ConversationId == conversationId && p.ApplicationUserId == userId);

        if (participant == null)
        {
            return 0;
        }

        return await _context.ChatMessages
            .AsNoTracking()
            .CountAsync(m =>
                m.ConversationId == conversationId &&
                m.SenderUserId != userId &&
                m.SentAtUtc > participant.LastReadAtUtc);
    }

    public async Task<long> GetUnreadCountAsync(string userId)
    {
        return await _context.ChatMessages
            .AsNoTracking()
            .CountAsync(m =>
                m.SenderUserId != userId &&
                m.Conversation.Participants.Any(p => p.ApplicationUserId == userId && m.SentAtUtc > p.LastReadAtUtc));
    }

    public async Task SaveChangesAsync()
    {
        await _context.SaveChangesAsync();
    }
}
