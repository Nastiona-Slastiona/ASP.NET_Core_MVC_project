using Microsoft.AspNetCore.Builder;
using WEB_953506_Kruglaya.Middleware;

namespace WEB_953506_Kruglaya.Extensions
{
    public static class AppExtensions
    {
        public static IApplicationBuilder UseFileLogging(this IApplicationBuilder app) => app.UseMiddleware<LogMiddleware>();
    }
}
