using System.Text.Json.Serialization;

namespace MeetingManagementShared.Exceptions;

public class AppError(string message, int statusCode = 400, List<string>? errors = null)
    : Exception(message)
{
    public int StatusCode { get; } = statusCode;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string> Errors { get; } = errors ?? [message];
}