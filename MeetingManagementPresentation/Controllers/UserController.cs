using MeetingManagementApplication.Dtos.User.Response;
using MeetingManagementApplication.Interfaces;
using MeetingManagementShared.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MeetingManagementPresentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController(IUserService userService) : BaseApiController
    {
        [HttpGet]
        //[Authorize(Roles = Roles.Admin)]
        public async Task<IActionResult> GetMeetings()
        {
            
            var users = await userService.GetMembers();

            var response = users.Select(u => new UserInfoDto
            {
                Id = u.Id,
                FullName = $"{u.FirstName} {u.LastName}"
            });

            return Success(response, "دریافت اطلاعات با موفقیت انجام شد");
        }

    }
}
