using MeetingManagementApplication.Dtos.Meeting.Command;
using MeetingManagementApplication.Interfaces;
using MeetingManagementApplication.Interfaces.Persistence;
using MeetingManagementDomain.Entities;

namespace MeetingManagementApplication.Services;

public class MeetingService(IUnitOfWork unitOfWork) : IMeetingService
{
    public async Task<IEnumerable<Meeting>> GetAllMeeting()
    {
        var meetings = await unitOfWork.MeetingRepository.GetAll();
        return meetings;
    }

    public async Task<Guid> CreateMeeting(CreateMeetingCommandDto command)
    {
        var meeting = new Meeting
        {
            Id = Guid.NewGuid(),
            Title = command.Title,
            Description = command.Description,
            CreatedAt = DateTime.UtcNow,
            Resolutions = command.Resolutions.Select(res => new Resolution
            {
                Id = Guid.NewGuid(),
                Content = res.Content,
                Deadline = res.Deadline,
                UserId = res.UserId
            }).ToList()
        };

        await unitOfWork.MeetingRepository.Add(meeting);
        await unitOfWork.SaveChangesAsync();

        return meeting.Id;
    }
}