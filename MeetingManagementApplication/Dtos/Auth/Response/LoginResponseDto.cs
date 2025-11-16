using System.Text.Json.Serialization;

namespace MeetingManagementApplication.Dtos.Auth.Response;

public class LoginResponseDto
{
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public string? Token { get; set; } = null!;
    public required UserDto UserInfo { get; set; }

}