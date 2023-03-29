using System.Net;
using Microsoft.EntityFrameworkCore;

namespace server.src.Middleware
{
    public class ErrorHandlerMiddleware : IMiddleware
    {
        public ErrorHandlerMiddleware() { }

        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            try
            {
                await next(context);
            }
            catch (DbUpdateException e)
            {
                context.Response.StatusCode = StatusCodes.Status400BadRequest;
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsJsonAsync(new ErrorResponse(HttpStatusCode.BadRequest, e.InnerException!.Message));
            }
            catch (Exception e)
            {
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                context.Response.ContentType = "application/json";
                await context.Response.WriteAsJsonAsync(new ErrorResponse(HttpStatusCode.InternalServerError, e.Message));
            }
        }
    }

    public class ErrorResponse
    {
        public HttpStatusCode ErrorCode { get; set; }
        public string Message { get; set; }

        public ErrorResponse(HttpStatusCode code, string message)
        {
            ErrorCode = code;
            Message = message;
        }
    }

    public static class ExceptionHandlerExtensions
    {
        public static IApplicationBuilder UseErrorHandler(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ErrorHandlerMiddleware>();
        }
    }
}