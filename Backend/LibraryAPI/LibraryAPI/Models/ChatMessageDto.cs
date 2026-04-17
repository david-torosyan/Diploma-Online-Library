namespace LibraryAPI.Models;

public class ChatMessageDto
{
    public long Id { get; set; }
    public Guid ConversationId { get; set; }
    public string SenderUserId { get; set; }
    public string SenderName { get; set; }
    public string Content { get; set; }
    public DateTime SentAtUtc { get; set; }
}
