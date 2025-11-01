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
            options.AddPolicy("AllowFrontend", policy =>
            {
                policy.WithOrigins("http://localhost:3000", "http://127.0.0.1:3000")
                      .AllowAnyHeader()
                      .AllowAnyMethod()
                      .AllowCredentials();
            });
        });
    }
}
