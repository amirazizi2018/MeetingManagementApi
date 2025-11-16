using MeetingManagementPresentation.Responses;
using Microsoft.AspNetCore.Mvc;

namespace MeetingManagementPresentation.Controllers
{
    [ApiController]
    public abstract class BaseApiController() : ControllerBase
    {
        protected IActionResult Success<T>(T data, string message = "عملیات موفق") =>
            Ok(new ApiResponse<T>(message, data));

        protected IActionResult Fail(string message, int statusCode = 400, List<string>? errors = null) =>
            StatusCode(statusCode, new ApiResponse<string>(message, null, errors ?? [message]));

        protected IActionResult Created<T>(T data, string message = "منبع با موفقیت ایجاد شد") =>
            StatusCode(201, new ApiResponse<T>(message, data));

        protected IActionResult NotFound(string message = "منبع یافت نشد") =>
            StatusCode(404, new ApiResponse<string>(message, null, [message]));

        protected IActionResult Forbidden(string message = "دسترسی غیرمجاز") =>
            StatusCode(403, new ApiResponse<string>(message, null, [message]));


    }
}
