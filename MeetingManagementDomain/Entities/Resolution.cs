namespace MeetingManagementDomain.Entities;

public class Resolution: BaseEntity
{

    public required string Content { get; set; }
    
    public DateTime Deadline { get; set; }

    public Guid MeetingId { get; set; }

    public Meeting? Meeting { get; set; }

    public Guid UserId { get; set; }

    public User? AssignedTo { get; set; }

    

}