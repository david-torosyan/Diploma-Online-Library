using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace LibraryAPI.Models;

public class AddBookDto
{
    [Required]
    public string Title { get; set; }
    [Required]
    public string AuthorName { get; set; }
    [Required]
    public int CategoryId { get; set; }
    public string? Description { get; set; }
    public DateTime? PublishedDate { get; set; }
    public string? BookUrl { get; set; }
    public string? ImageUrl { get; set; }
    public IFormFile? BookFile { get; set; }
    public IFormFile? ImageFile { get; set; }
}

