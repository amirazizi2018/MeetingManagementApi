namespace MeetingManagementApplication.Dtos.Resolution.Response;

public class ResolutionUserDto
{
    public Guid Id { get; set; }

    public string Content { get; set; } = null!;

    public DateTime Deadline { get; set; } = default!;

    public int ProgressPercent { get; set; } = 0;
}