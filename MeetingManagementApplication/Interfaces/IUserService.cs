using MeetingManagementDomain.Entities;

namespace MeetingManagementApplication.Interfaces;

public interface IUserService
{
    Task<IEnumerable<User>> GetMembers();

}