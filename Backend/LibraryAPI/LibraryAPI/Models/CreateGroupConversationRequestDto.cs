using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Models;

public class CreateGroupConversationRequestDto
{
    [Required]
    [StringLength(120, MinimumLength = 2)]
    public string Name { get; set; }

    [MinLength(1)]
    public List<string> ParticipantUserIds { get; set; } = new();
}
