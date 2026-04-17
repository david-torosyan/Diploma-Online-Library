namespace Library.DAL.Models;

public class ChatMessage
{
    public long Id { get; set; }
    public Guid ConversationId { get; set; }
    public Conversation Conversation { get; set; }

    public string SenderUserId { get; set; }
    public ApplicationUser SenderUser { get; set; }

    public string Content { get; set; }
    public DateTime SentAtUtc { get; set; } = DateTime.UtcNow;
}
