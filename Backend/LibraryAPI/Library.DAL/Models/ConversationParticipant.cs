namespace Library.DAL.Models;

public class ConversationParticipant
{
    public Guid ConversationId { get; set; }
    public Conversation Conversation { get; set; }

    public string ApplicationUserId { get; set; }
    public ApplicationUser User { get; set; }

    public DateTime JoinedAtUtc { get; set; } = DateTime.UtcNow;
    public DateTime LastReadAtUtc { get; set; } = DateTime.MinValue;
}
