namespace Library.DAL.Models;

public class Conversation
{
    public Guid Id { get; set; }
    public bool IsGroup { get; set; }
    public string? Name { get; set; }
    public string CreatedByUserId { get; set; }
    public ApplicationUser CreatedByUser { get; set; }
    public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime LastMessageAtUtc { get; set; } = DateTime.UtcNow;

    public ICollection<ConversationParticipant> Participants { get; set; } = new List<ConversationParticipant>();
    public ICollection<ChatMessage> Messages { get; set; } = new List<ChatMessage>();
}
