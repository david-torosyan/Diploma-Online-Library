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
    [Required]
    public string Description { get; set; }
    [Required]
    public string ISBN { get; set; }
    [Required]
    public DateTime PublishedDate { get; set; }
    [Required]
    public string BookUrl { get; set; }
    [Required]
    public string ImageUrl { get; set; }
}

