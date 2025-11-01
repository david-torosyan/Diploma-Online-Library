using Library.DAL.Data;
using Library.DAL.Models;
using LibraryAPI.Models;
using LibraryAPI.Services.IServices;
using Microsoft.AspNetCore.Identity;

namespace LibraryAPI.Services;

public class UserService : IUserService
{
    private readonly ApplicationDbContext _db;
    private readonly UserManager<ApplicationUser> _userManager;
    private readonly RoleManager<IdentityRole> _roleManager;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;

    public UserService(ApplicationDbContext db, IJwtTokenGenerator jwtTokenGenerator,
        UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
    {
        _db = db;
        _jwtTokenGenerator = jwtTokenGenerator;
        _userManager = userManager;
        _roleManager = roleManager;
    }

    public string Register(RegisterModel registrationRequestDto)
    {
        // Perform user registration logic here
        var user = new ApplicationUser
        {
            FirstName = registrationRequestDto.FirstName,
            LastName = registrationRequestDto.LastName,
            UserName = registrationRequestDto.Email.ToLower(),
            Email = registrationRequestDto.Email,
            NormalizedEmail = registrationRequestDto.Email.ToUpper(),
        };


        try
        {
            var result = _userManager.CreateAsync(user, registrationRequestDto.Password).Result;
            if (result.Succeeded)
            {
                var userToReturn = _db.Users.First(u => u.UserName == registrationRequestDto.Email);

                UserDto userDto = new()
                {
                    Email = userToReturn.Email,
                    Id = userToReturn.Id,
                    FirstName = userToReturn.FirstName
                };

                return string.Empty;

            }
            else
            {
                return result.Errors.FirstOrDefault().Description;
            }

        }
        catch
        {
            throw;
        }
    }

    public UserDto GetTheLattesUser()
    {
        var user = _db.Users.FirstOrDefault();
        return new()
        {
            Email = user.Email,
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName
        };
    }

    public LoginResponseDto Login(LoginModel loginRequestDto)
    {
        // Perform login logic here
        var user = _db.Users.FirstOrDefault(u => u.UserName.ToLower() == loginRequestDto.Email.ToLower());

        bool isValid = _userManager.CheckPasswordAsync(user, loginRequestDto.Password).Result;

        if (user == null || isValid == false)
        {
            return new LoginResponseDto() { User = null, Token = "" };
        }

        // Return a token or any other relevant information
        var roles = _userManager.GetRolesAsync(user).Result;
        var token = _jwtTokenGenerator.GenerateToken(user, roles);

        UserDto userDTO = new()
        {
            Email = user.Email,
            Id = user.Id,
            FirstName = user.FirstName,
            LastName = user.LastName

        };
        LoginResponseDto loginResponseDto = new LoginResponseDto()
        {
            User = userDTO,
            Token = token
        };

        return loginResponseDto;
    }

    public async Task<bool> AssignRole(string email, string roleName)
    {
        var user = _db.Users.FirstOrDefault(u => u.Email.ToLower() == email.ToLower());
        if (user != null)
        {
            if (!_roleManager.RoleExistsAsync(roleName).GetAwaiter().GetResult())
            {
                //create role if it does not exist
                _roleManager.CreateAsync(new IdentityRole(roleName)).GetAwaiter().GetResult();
            }
            await _userManager.AddToRoleAsync(user, roleName);
            return true;
        }
        return false;
    }

    public void Delete(string id)
    {
        // Find the user by Id
        var user = _userManager.FindByIdAsync(id).Result;

        if (user != null)
        {
            // Delete the user
            var result = _userManager.DeleteAsync(user).Result;

            if (!result.Succeeded)
            {
                // Optionally, handle errors
                throw new Exception(result.Errors.First().Description);
            }
        }
        else
        {
            throw new Exception("User not found");
        }
    }
}
