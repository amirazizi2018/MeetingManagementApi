using MeetingManagementApplication.Interfaces;
using MeetingManagementDomain.Entities;
using MeetingManagementShared.Enums;

namespace MeetingManagementApplication.Services;

public class UserService(IGenericRepository<User> userRepo): IUserService {
    

    public async Task<IEnumerable<User>> GetMembers()
    {
        var members = await userRepo.GetMany(u=> u.Role == UserRole.Member);
        return members;
    }
}