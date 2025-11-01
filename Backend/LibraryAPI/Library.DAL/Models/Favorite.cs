namespace Library.DAL.Models;

public class Favorite
{
    public string ApplicationUserId { get; set; }  // FK to user
    public ApplicationUser User { get; set; }

    public int BookId { get; set; } // FK to book
    public Book Book { get; set; }

    public DateTime AddedAt { get; set; } = DateTime.UtcNow;
}
