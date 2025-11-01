using LibraryAPI.Models;
using LibraryAPI.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UserController : ControllerBase
{
    private readonly IUserService _userService;

    public UserController(IUserService userService)
    {
        _userService = userService;
    }

    [HttpPost("register")]
    [ProducesResponseType(typeof(RegisterResponseDto), 200)]
    [ProducesResponseType(typeof(RegisterResponseDto), 400)]
    public ActionResult<RegisterResponseDto> Register([FromBody] RegisterModel model)
    {
        if (model == null)
            return BadRequest("Invalid registration data.");

        var message = _userService.Register(model);

        if (!string.IsNullOrEmpty(message))
        {
            return BadRequest(new RegisterResponseDto { Message = message });
        }

        return Ok(new RegisterResponseDto { Email = model.Email, Message = "Registration successful." });
    }

    [HttpPost("login")]
    [ProducesResponseType(typeof(LoginResponseDto), 200)]
    [ProducesResponseType(typeof(string), 400)]
    public ActionResult<LoginResponseDto> Login([FromBody] LoginModel model)
    {
        if (model == null)
            return BadRequest("Invalid login data.");

        var loginResponse = _userService.Login(model);

        if (loginResponse.User == null)
        {
            return BadRequest(new { error = "Username or password is incorrect." });
        }

        return Ok(loginResponse);
    }

    [HttpGet("profile")]
    [Authorize]
    public IActionResult GetProfile()
    {
        var user = _userService.GetTheLattesUser();

        return Ok(user);
    }
}
