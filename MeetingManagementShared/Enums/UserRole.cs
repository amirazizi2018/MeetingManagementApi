using System.ComponentModel.DataAnnotations;

namespace MeetingManagementShared.Enums;

public enum UserRole
{
    [Display(Name = "مدیر سیستم")]
    Admin,

    [Display(Name = "اعضاء")]
    Member
}