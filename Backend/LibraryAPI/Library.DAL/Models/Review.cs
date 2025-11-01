namespace Library.DAL.Models;

public class Review
{
    public int Id { get; set; }
    public string ApplicationUserId { get; set; } // FK to user
    public ApplicationUser User { get; set; }

    public int BookId { get; set; } // FK to book
    public Book Book { get; set; }

    public string Content { get; set; }
    public int Rating { get; set; } // 1-5
    public DateTime CreatedAt { get; set; }
}
