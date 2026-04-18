namespace LibraryAPI.Models;

public class BookDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string ImageURL { get; set; }
    public bool IsImageOnS3 { get; set; }
    public double AverageRating { get; set; }
    public int ReviewsCount { get; set; }
}
