
using MeetingManagementPresentation.Responses;
using System.Net;
using MeetingManagementShared.Exceptions;

namespace MeetingManagementPresentation.Middleware;

public class ErrorHandlingMiddleware(RequestDelegate next)
{
    public async Task Invoke(HttpContext context)
    {
        try
        {
            await next(context);
        }
        catch (AppError ex)
        {
            context.Response.StatusCode = ex.StatusCode;
            context.Response.ContentType = "application/json";

            var response = new ApiResponse<string>(ex.Message, null, ex.Errors);
            await context.Response.WriteAsJsonAsync(response);
        }
        catch (Exception ex)
        {
            context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.Response.ContentType = "application/json";

            var response = new ApiResponse<string>("خطای داخلی سرور", null, [ex.Message]);
            await context.Response.WriteAsJsonAsync(response);
        }
    }

}