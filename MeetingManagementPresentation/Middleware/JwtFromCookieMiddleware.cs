namespace MeetingManagementPresentation.Middleware;

public class JwtFromCookieMiddleware(RequestDelegate next)
{
    public async Task InvokeAsync(HttpContext context)
    {
        var token = context.Request.Cookies["AccessToken"];

        if (!string.IsNullOrEmpty(token) &&
            !context.Request.Headers.ContainsKey("Authorization"))
        {
            context.Request.Headers.Append("Authorization", $"Bearer {token}");
        }

        await next(context);
    }
}