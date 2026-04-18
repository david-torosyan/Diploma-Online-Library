using LibraryAPI.Middleware;

namespace LibraryAPI.Extension;

public static class ProgramExtension
{
    public static void ConfigureCustomExceptionHandler(this IApplicationBuilder app)
    {
        app.UseMiddleware<GlobalExceptionHandlingMiddleware>();
    }

    public static void ConfigureCors(this IServiceCollection services)
    {
        services.AddCors(options =>
        {
            options.AddPolicy("AllowAll", policy =>
            {
                policy.AllowAnyOrigin()
                      .AllowAnyHeader()
                      .AllowAnyMethod();
            });
        });
    }
}
