namespace LibraryAPI.Models;

public class ConversationSummaryDto
{
    public Guid Id { get; set; }
    public bool IsGroup { get; set; }
    public string Title { get; set; }
    public DateTime LastMessageAtUtc { get; set; }
    public int UnreadCount { get; set; }
    public List<ChatUserDto> Participants { get; set; } = new();
    public ChatMessageDto? LastMessage { get; set; }
}
