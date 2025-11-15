using System.Data;

namespace MeetingManagementDomain.Entities;

public class User
{
    public Guid Id { get; set; }

    public required string FirstName { get; set; }

    public required string LastName { get; set; }

    public required string Email { get; set; }

    public required string Password { get; set; }

    public Role Role { get; set; }

    public ICollection<Resolution> AssignedResolutions { get; set; } = new List<Resolution>();


}

public enum Role
{
    Admin,
    Member
}
