using MeetingManagementApplication.Interfaces;
using MeetingManagementDomain.Entities;

namespace MeetingManagementApplication.Services;

public class MeetingService(IGenericRepository<Meeting> meetingRepo): IMeetingService
{
    public async Task<IEnumerable<Meeting>> GetAllMeeting()
    {
        var meetings = await meetingRepo.GetAll();
        return meetings;
    }
}