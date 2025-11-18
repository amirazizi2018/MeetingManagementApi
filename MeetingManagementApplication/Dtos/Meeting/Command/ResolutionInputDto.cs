using System.ComponentModel.DataAnnotations;

namespace MeetingManagementApplication.Dtos.Meeting.Command;

public class ResolutionInputDto
{
    [Required]
    public string Content { get; set; } = null!;

    [Required]
    public DateTime Deadline { get; set; }

    [Required]
    public Guid UserId { get; set; }
}

