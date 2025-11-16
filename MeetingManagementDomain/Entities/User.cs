using MeetingManagementShared.Enums;
using System.Data;

namespace MeetingManagementDomain.Entities;

public class User: BaseEntity
{

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required string Email { get; set; }

    public required string Password { get; set; }

    public UserRole Role { get; set; }

    public ICollection<Resolution> AssignedResolutions { get; set; } = new List<Resolution>();


}

