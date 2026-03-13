using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models;

public class AddBookDto
{
    [Required]
    public string Title { get; set; }
    [Required]
    public string AuthorName { get; set; }
    [Required]
    public int CategoryId { get; set; }
    public string Description { get; set; }
    public string ISBN { get; set; }
    public DateTime PublishedDate { get; set; }
    [Required]
    public string BookUrl { get; set; }
    [Required]
    public string ImageUrl { get; set; }
}

