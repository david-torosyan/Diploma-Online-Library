namespace LibraryAPI.Models;

public class ReviewDto
{
	public int Id { get; set; }
	public int BookId { get; set; }
	public string ApplicationUserId { get; set; } = string.Empty;
	public string ReviewerName { get; set; } = string.Empty;
	public string Content { get; set; } = string.Empty;
	public int Rating { get; set; }
	public DateTime CreatedAt { get; set; }
}
