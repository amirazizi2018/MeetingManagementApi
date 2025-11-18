using MeetingManagementApplication.Dtos.Meeting.Command;
using MeetingManagementApplication.Dtos.Meeting.Response;
using MeetingManagementApplication.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MeetingManagementPresentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MeetingController(IMeetingService meetingService) : BaseApiController
    {
        [HttpGet]
        public async Task<IActionResult> GetMeetings()
        {
            
            var meetings = await meetingService.GetAllMeeting();


            return Success(meetings, "دریافت اطلاعات با موفقیت انجام شد");
        }
        
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> CreateMeeting(CreateMeetingCommandDto command)
        {
            
            var id = await meetingService.CreateMeeting(command);

            
            return Success(id, "اطلاعات جلسه با موفقیت ثبت شد");
        }

    }
}
