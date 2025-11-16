namespace MeetingManagementApplication.Dtos.Meeting.Response;

public class MeetingDto
{
    public Guid Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime MeetingDate { get; set; } = default!;
}