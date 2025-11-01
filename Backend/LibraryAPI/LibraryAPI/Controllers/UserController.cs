using LibraryAPI.Models;
using LibraryAPI.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        /// <summary>
        /// Registers a new user in the system.
        /// </summary>
        /// <param name="model">User registration data.</param>
        /// <returns>A response message indicating success or failure.</returns>
        [HttpPost("register")]
        [ProducesResponseType(typeof(RegisterResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(RegisterResponseDto), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public ActionResult<RegisterResponseDto> Register([FromBody] RegisterModel model)
        {
            if (model == null)
                return BadRequest("Invalid registration data.");

            var message = _userService.Register(model);

            if (!string.IsNullOrEmpty(message))
                return BadRequest(new RegisterResponseDto { Message = message });

            return Ok(new RegisterResponseDto
            {
                Email = model.Email,
                Message = "Registration successful."
            });
        }

        /// <summary>
        /// Authenticates a user and returns a JWT token if valid credentials are provided.
        /// </summary>
        /// <param name="model">User login credentials.</param>
        /// <returns>A JWT token and user info if login is successful.</returns>
        [HttpPost("login")]
        [ProducesResponseType(typeof(LoginResponseDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public ActionResult<LoginResponseDto> Login([FromBody] LoginModel model)
        {
            if (model == null)
                return BadRequest("Invalid login data.");

            var loginResponse = _userService.Login(model);

            if (loginResponse.User == null)
                return BadRequest(new { error = "Username or password is incorrect." });

            return Ok(loginResponse);
        }

        /// <summary>
        /// Retrieves the latest authenticated user's profile.
        /// </summary>
        /// <returns>User profile details.</returns>
        [HttpGet("profile")]
        [Authorize]
        [ProducesResponseType(typeof(UserDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public IActionResult GetProfile()
        {
            var user = _userService.GetTheLattesUser();

            if (user == null)
                return Unauthorized("User not found or unauthorized.");

            return Ok(user);
        }
    }
}
