using MeetingManagementApplication.Dtos.Auth.Command;
using MeetingManagementApplication.Interfaces;
using MeetingManagementDomain.Entities;
using MeetingManagementShared.Enums;
using MeetingManagementShared.Helper;


namespace MeetingManagementApplication.Services;

public class AuthService(IGenericRepository<User> userRepo) : IAuthService
{
    public async Task<User?> Authenticate(LoginCommandDto command)
    {

        var parsedRole = EnumHelper.ParseEnum<UserRole>(command.Role, "نقش");

        var user = await userRepo.Get(u => u.Email == command.Email && u.Role == parsedRole);

        if (user == null || !BCrypt.Net.BCrypt.Verify(command.Password, user.Password))
            return null;

        return user;

    }
}