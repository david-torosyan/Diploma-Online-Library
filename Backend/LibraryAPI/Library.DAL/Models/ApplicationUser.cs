using Microsoft.AspNetCore.Identity;

namespace Library.DAL.Models;

public class ApplicationUser : IdentityUser
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    // Navigation property
    public ICollection<Favorite> Favorites { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<ConversationParticipant> ConversationParticipants { get; set; }
    public ICollection<Conversation> ConversationsCreated { get; set; }
    public ICollection<ChatMessage> ChatMessagesSent { get; set; }
}
