using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models;

public class SendMessageRequestDto
{
    [Required]
    [StringLength(2000, MinimumLength = 1)]
    public string Content { get; set; }
}
