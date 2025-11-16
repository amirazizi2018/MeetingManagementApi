using MeetingManagementApplication.Dtos.Auth.Command;
using MeetingManagementDomain.Entities;

namespace MeetingManagementApplication.Interfaces;

public interface IMeetingService
{
    Task<IEnumerable<Meeting>> GetAllMeeting();

}