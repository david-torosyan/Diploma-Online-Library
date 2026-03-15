using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models;

public class UpsertReviewDto
{
    [Range(1, 5)]
    public int Rating { get; set; }

    [Required]
    [StringLength(1000, MinimumLength = 3)]
    public string Content { get; set; } = string.Empty;
}
