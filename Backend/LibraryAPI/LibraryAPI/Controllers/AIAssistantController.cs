using LibraryAPI.Models;
using LibraryAPI.Services;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Controllers
{
    public class AIAssistantController : Controller
    {
        public readonly AIAssistantHelper _aIAssistantHelper;
        public AIAssistantController(AIAssistantHelper aIAssistantHelper)
        {
            _aIAssistantHelper = aIAssistantHelper;
        }

        [HttpGet("prompt")]
        [ProducesResponseType(typeof(string), 200)]
        [ProducesResponseType(400)]
        public async Task<ActionResult<string>> GetAIRequest([Required] string prompt)
        {
            if (string.IsNullOrWhiteSpace(prompt))
                return BadRequest("Prompt cannot be empty.");

            var result = await _aIAssistantHelper.GenerateContentAsync(prompt);
            return Ok(result);
        }


        [HttpGet("getBook")]
        public async Task<ActionResult<BookWithDetailsDto>> GetBookByAI([Required] string prompt) =>
            Ok(await _aIAssistantHelper.GenerateBookWithDetailsAsync(prompt));
    }
}
