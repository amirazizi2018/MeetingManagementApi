namespace MeetingManagementApplication.Dtos.Auth.Response;

public class UserDto
{
    public Guid Id { get; set; }
    public required string FirstName { get; set; } = null!;
    public required string LastName { get; set; } = null!;
    public required string Email { get; set; } = null!;
    public required string Role { get; set; } = null!;

}