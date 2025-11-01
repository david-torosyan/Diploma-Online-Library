using LibraryAPI.Models;
using Newtonsoft.Json;
using System.Net;

namespace LibraryAPI.Middleware;

public class GlobalExceptionHandlingMiddleware
{
    private readonly RequestDelegate _next;
    private readonly ILogger _logger;

    public GlobalExceptionHandlingMiddleware(RequestDelegate next, ILogger<GlobalExceptionHandlingMiddleware> logger)
    {
        _next = next;
        _logger = logger;
    }

    public async Task Invoke(HttpContext context)
    {
        try
        {
            await _next(context);
        }
        catch (Exception ex)
        {
            _logger.LogError(message: $"[-Something went wrong-]: {ex}");
            await HandleExceptionAsync(context, ex);
        }
    }

    private static async Task HandleExceptionAsync(HttpContext context, Exception exception)
    {
        context.Response.ContentType = "application/json";
        context.Response.StatusCode = exception switch
        {
            KeyNotFoundException => (int)HttpStatusCode.NotFound,
            FileNotFoundException => (int)HttpStatusCode.NotFound,
            ArgumentException => (int)HttpStatusCode.BadRequest,
            InvalidOperationException => (int)HttpStatusCode.BadRequest,
            UnauthorizedAccessException => (int)HttpStatusCode.Unauthorized,
            _ => (int)HttpStatusCode.InternalServerError,
        };

        var response = new ErrorDetails
        {
            StatusCode = context.Response.StatusCode,
            Message = exception?.Message,
            StackTrace = exception?.StackTrace,
        };

        await context.Response.WriteAsync(JsonConvert.SerializeObject(response));
    }
}
