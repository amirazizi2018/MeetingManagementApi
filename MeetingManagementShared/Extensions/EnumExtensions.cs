using System.ComponentModel.DataAnnotations;
using System.Reflection;
using MeetingManagementShared.Exceptions;

namespace MeetingManagementShared.Extensions;

public static class EnumExtensions
{
    /// <summary>
    /// تبدیل رشته به Enum با کنترل خطا و پیام فارسی
    /// </summary>
    //public static T Parse<T>(this T _, string value, string fieldName = "مقدار") where T : struct, Enum
    //{
    //    if (!Enum.TryParse<T>(value, true, out var result))
    //        throw new AppError($"{fieldName} وارد شده معتبر نیست. مقادیر مجاز: {string.Join(", ", Enum.GetNames(typeof(T)))}", 400);

    //    return result;
    //}

    /// <summary>
    /// تبدیل امن رشته به Enum بدون پرتاب خطا
    /// </summary>
    //public static bool TryParse<T>(this T _, string value, out T result) where T : struct, Enum
    //{
    //    return Enum.TryParse<T>(value, true, out result);
    //}

    /// <summary>
    /// دریافت متن فارسی از DisplayAttribute روی Enum
    /// </summary>
    //public static string GetLabel(this Enum value)
    //{
    //    var field = value.GetType().GetField(value.ToString());
    //    var attr = field?.GetCustomAttribute<DisplayAttribute>();
    //    return attr?.Name ?? value.ToString();
    //}
}