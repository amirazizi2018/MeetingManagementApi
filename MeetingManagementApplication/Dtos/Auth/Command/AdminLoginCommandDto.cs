using MeetingManagementShared.Enums;
using System.ComponentModel.DataAnnotations;

namespace MeetingManagementApplication.Dtos.Auth.Command;

public class AdminLoginCommandDto: IValidatableObject
{
    [Required(ErrorMessage = "ایمیل الزامی است")]
    [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نیست")]
    public required string Email { get; set; }

    [Required(ErrorMessage = "رمز عبور الزامی است")]
    [MinLength(6, ErrorMessage = "رمز عبور باید حداقل ۶ کاراکتر باشد")]
    public required string Password { get; set; }

    [Required(ErrorMessage = "نقش الزامی است")]
    public required string Role { get; set; }

    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    {
        var validRoles = Enum.GetNames(typeof(UserRole));

        if (!validRoles.Contains(Role, StringComparer.OrdinalIgnoreCase))
        {
            yield return new ValidationResult(
                "نقش وارد شده معتبر نیست.",
                new[] { nameof(Role) }
            );
        }
    }


}