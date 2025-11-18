using MeetingManagementApplication.Dtos.Resolution.Command;
using MeetingManagementApplication.Dtos.Resolution.Response;
using MeetingManagementApplication.Interfaces;
using MeetingManagementShared.Constants;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace MeetingManagementPresentation.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResolutionController(IResolutionService resolutionService) : BaseApiController
    {
        /// <summary>
        /// متد دریافت userId از توکن
        /// </summary>
        private Guid? GetCurrentUserId()
        {
            var userIdClaim = User.FindFirst(ClaimTypes.NameIdentifier);

            if (userIdClaim is null || !Guid.TryParse(userIdClaim.Value, out var userId))
                return null;

            return userId;
        }



        [HttpGet("user")]
        [Authorize(Roles = Roles.Member)]
        public async Task<IActionResult> GetResolutionsByUserId()
        {
            var userId = GetCurrentUserId();

            if (userId is null)
                return NotFound( "اطلاعات کاربر یافت نشد");


            var resolutions = await resolutionService.GetResolutionsByUserId(userId.Value);

            var response = resolutions.Select(r => new ResolutionUserDto
            {
                Id = r.Id,
                Content = r.Content,
                Deadline = r.Deadline,
                ProgressPercent = r.ProgressPercent
            });

            return Success(response, "دریافت اطلاعات با موفقیت انجام شد");
        }

        [HttpPut("{id}/progress")]
        [Authorize(Roles = Roles.Member)]
        public async Task<IActionResult> UpdateProgress(Guid id, [FromBody] ProgressUpdateCommandDto command)
        {
            var progressPercent = command.ProgressPercent;
            if (progressPercent is < 0 or > 100)
            {
                return Fail("درصد پیشرفت باید بین ۰ تا ۱۰۰ باشد.");
            }

            var updated = await resolutionService.UpdateProgress(id, progressPercent);

            return !updated ? NotFound("مصوبه‌ای با این شناسه یافت نشد.") : Success(updated, "درصد پیشرفت با موفقیت به‌روزرسانی شد.");
        }

    }
}
