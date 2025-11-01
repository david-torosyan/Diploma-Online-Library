using LibraryAPI.Models;

namespace LibraryAPI.Services.IServices;

public interface IUserService
{
    string Register(RegisterModel registrationRequestDto);
    LoginResponseDto Login(LoginModel loginRequsestDto);
    Task<bool> AssignRole(string email, string roleName);
    UserDto GetTheLattesUser();
    void Delete(string id);
}
