using Library.DAL.IRepositories;
using LibraryAPI.Mappers;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        /// <summary>
        ///  Retrieves a list of all book categories.
        /// </summary>
        /// <remarks>This method returns a collection of categories, each represented as a <see
        /// cref="CategoryDto"/> object.  It responds with an HTTP 200 status code if the operation is successful, or an
        /// appropriate error status code otherwise.</remarks>
        /// <returns> objects representing all book categories.</returns>
        [HttpGet("allCategories")]
        [ProducesResponseType(typeof(IEnumerable<CategoryDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<CategoryDto>>> GetBooksByCategory() =>
             Ok((await _unitOfWork.Categories.GetAllAsync()).Select(category => category.ToCategoryDto()));
    }
}
