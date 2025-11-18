using MeetingManagementApplication.Dtos.Auth.Command;
using MeetingManagementApplication.Dtos.Meeting.Command;
using MeetingManagementDomain.Entities;

namespace MeetingManagementApplication.Interfaces;

public interface IMeetingService
{
    Task<IEnumerable<Meeting>> GetAllMeeting();

    Task<Guid> CreateMeeting(CreateMeetingCommandDto command);


}