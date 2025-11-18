using MeetingManagementDomain.Entities;

namespace MeetingManagementApplication.Interfaces;

public interface IResolutionService
{
    /// <summary>
    /// دریافت لیست مصوبات مربوط به یک کاربر خاص
    /// </summary>
    Task<IEnumerable<Resolution>> GetResolutionsByUserId(Guid userId);

    /// <summary>
    /// به‌روزرسانی درصد پیشرفت یک مصوبه خاص
    /// </summary>
    Task<bool> UpdateProgress(Guid resolutionId, int progressPercent);


}