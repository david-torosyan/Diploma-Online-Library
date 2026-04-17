using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models;

public class CreatePrivateConversationRequestDto
{
    [Required]
    public string RecipientUserId { get; set; }
}
