namespace LibraryAPI.Models;

public class ChatUserDto
{
    public string Id { get; set; }
    public string DisplayName { get; set; }
    public string? Email { get; set; }
    public bool IsOnline { get; set; }
}
