using System.Text.Json.Serialization;

namespace MeetingManagementPresentation.Responses;

public class ApiResponse<T>(string message, T? data = default, List<string>? errors = null)
{
    public string Message { get; set; } = message;
    
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public T? Data { get; set; } = data;

    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public List<string>? Errors { get; set; } = errors;
}