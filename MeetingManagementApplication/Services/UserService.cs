using MeetingManagementApplication.Interfaces;
using MeetingManagementApplication.Interfaces.Persistence;
using MeetingManagementDomain.Entities;
using MeetingManagementShared.Enums;

namespace MeetingManagementApplication.Services;

public class UserService(IUnitOfWork unitOfWork) : IUserService {
    

    public async Task<IEnumerable<User>> GetMembers()
    {
        var members = await unitOfWork.UserRepository.GetMany(u=> u.Role == UserRole.Member);
        return members;
    }
}