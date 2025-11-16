using MeetingManagementApplication.Dtos.Auth.Command;
using MeetingManagementDomain.Entities;

namespace MeetingManagementApplication.Interfaces;

public interface IAuthService
{
    Task<User?> Authenticate(AdminLoginCommandDto command);

}