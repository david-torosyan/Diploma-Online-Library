using Library.DAL.Data;
using Library.DAL.IRepositories;
using Library.DAL.Models;
using Library.DAL.Repositories;
using LibraryAPI.Hubs;
using LibraryAPI.Extension;
using LibraryAPI.Models;
using LibraryAPI.Services;
using LibraryAPI.Services.IServices;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.FileProviders;
using Microsoft.EntityFrameworkCore;
using System.Text.Encodings.Web;
using System.Text.Unicode;

var builder = WebApplication.CreateBuilder(args);

#region ========================== CORS Configuration ==========================
builder.Services.ConfigureCors();
#endregion

#region ========================== Database Configuration ==========================
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("DefaultConnection"), sqlOptions =>
    {
        sqlOptions.EnableRetryOnFailure(); // Handle transient failures gracefully
    }));
#endregion

#region ========================== Identity Configuration ==========================
builder.Services.AddIdentity<ApplicationUser, IdentityRole>()
    .AddEntityFrameworkStores<ApplicationDbContext>()
    .AddDefaultTokenProviders();
#endregion

#region ========================== App Options ==========================
builder.Services.Configure<AIAssistantOptions>(builder.Configuration.GetSection("AIAssistant"));
builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection("JwtOptions"));
#endregion

#region ========================== JWT Authentication ==========================
builder.AddAppAuthetication();
#endregion

#region ========================== Dependency Injection (Repositories & Services) ==========================
builder.Services.AddScoped<IAuthorRepository, AuthorRepository>();
builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IBookRepository, BookRepository>();
builder.Services.AddScoped<IFavoriteRepository, FavoriteRepository>();
builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
builder.Services.AddScoped<IConversationRepository, ConversationRepository>();
builder.Services.AddScoped<IChatMessageRepository, ChatMessageRepository>();
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IBookAuthorService, BookAuthorService>();
builder.Services.AddScoped<IReviewService, ReviewService>();
builder.Services.AddScoped<IChatService, ChatService>();
builder.Services.AddScoped<IJwtTokenGenerator, JwtTokenGenerator>();
builder.Services.AddSingleton<IOnlineUserTracker, OnlineUserTracker>();
builder.Services.AddSingleton<IUserIdProvider, SubClaimUserIdProvider>();
builder.Services.AddScoped<AIAssistantHelper, AIAssistantHelper>();
builder.Services.AddHttpClient<AIAssistantHelper>();

builder.Services.AddHttpContextAccessor();
builder.Services.AddSignalR();
#endregion

#region ========================== Controller & JSON Settings ==========================
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.Encoder = JavaScriptEncoder.Create(UnicodeRanges.All);
    options.JsonSerializerOptions.WriteIndented = true;
});
#endregion

#region ========================== Swagger Configuration ==========================
builder.Services.AddModSwaggerGen();
#endregion

var app = builder.Build();

var picturesPath = Path.Combine(app.Environment.ContentRootPath, "Media", "pictures");
var pdfsPath = Path.Combine(app.Environment.ContentRootPath, "Media", "pdfs");
Directory.CreateDirectory(picturesPath);
Directory.CreateDirectory(pdfsPath);

#region ========================== Database Migration ==========================
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    try
    {
        db.Database.Migrate(); // Automatically apply migrations
        Console.WriteLine("✅ Database migration applied successfully.");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"⚠️ Database migration failed: {ex.Message}");
    }
}
#endregion

#region ========================== Middleware Pipeline ==========================
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider(Path.Combine(app.Environment.ContentRootPath, "Media")),
    RequestPath = "/media"
});

app.UseCors("AllowFrontend");
app.UseAuthentication();
app.UseAuthorization();

app.ConfigureCustomExceptionHandler();

app.MapControllers();
app.MapHub<ChatHub>("/hubs/chat");
#endregion

app.Run();
