using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models;

public class AddConversationParticipantRequestDto
{
    [Required]
    public string UserId { get; set; }
}
