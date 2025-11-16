using MeetingManagementShared.Exceptions;

namespace MeetingManagementShared.Helper;

public static class EnumHelper
{
    public static T ParseEnum<T>(string value, string fieldName = "مقدار") where T : struct, Enum
    {
        if (!Enum.TryParse<T>(value, true, out var result))
            throw new AppError($"{fieldName} وارد شده معتبر نیست. مقادیر مجاز: {string.Join(", ", Enum.GetNames(typeof(T)))}", 400);

        return result;
    }
}
