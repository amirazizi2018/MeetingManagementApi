using MeetingManagementApplication.Dtos.Auth.Command;
using MeetingManagementApplication.Dtos.Auth.Response;
using MeetingManagementApplication.Interfaces;
using MeetingManagementApplication.Services;
using MeetingManagementShared.Enums;
using MeetingManagementShared.Exceptions;
using MeetingManagementShared.Helper;
using Microsoft.AspNetCore.Mvc;

namespace MeetingManagementPresentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController(IAuthService authService, JwtService jwtService) : BaseApiController
    {
        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody] LoginCommandDto command)
        {
            var parsedRole = EnumHelper.ParseEnum<UserRole>(command.Role, "نقش");

            var user = await authService.Authenticate(command);

            if (user == null)
                throw new AppError("نام کاربری یا رمز عبور اشتباه است", 401);

            var token = jwtService.GenerateToken(user);

            if (parsedRole == UserRole.Admin)
            {
                Response.Cookies.Append("AccessToken", token, new CookieOptions
                {
                    HttpOnly = true,
                    Secure = true,
                    SameSite = SameSiteMode.Strict,
                    Expires = DateTimeOffset.UtcNow.AddMinutes(60 * 12),
                    Domain = ".meeting.com"
                });
            }


            var response = new LoginResponseDto
            {
                Token = parsedRole == UserRole.Member ? token : null,
                UserInfo = new UserDto
                {
                    Id = user.Id,
                    FirstName = user.FirstName,
                    LastName = user.LastName,
                    Email = user.Email,
                    Role = user.Role.ToString()
                }
            };


            return Success(response, "ورود به سامانه با موفقیت انجام شد");


        }

    }
}
