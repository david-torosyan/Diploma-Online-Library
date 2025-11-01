using Library.DAL.IRepositories;
using Library.DAL.Models;
using LibraryAPI.Mappers;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        /// <summary>
        /// Retrieves all books belonging to the specified category.
        /// </summary>
        /// <param name="category">The category name to filter books by.</param>
        /// <returns>A list of books within the given category.</returns>
        [HttpGet("category")]
        [ProducesResponseType(typeof(IEnumerable<BookDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetBooksByCategory([Required] string category)
        {
            if (string.IsNullOrWhiteSpace(category))
                return BadRequest("Category cannot be empty.");

            var books = await _bookRepository.GetByCategoryAsync(category);
            return Ok(books.Select(book => book.ToBookDto()));
        }

        /// <summary>
        /// Retrieves a single book with detailed information by its ID.
        /// </summary>
        /// <param name="id">The unique identifier of the book.</param>
        /// <returns>The book details if found; otherwise, 404.</returns>
        [HttpGet("id")]
        [ProducesResponseType(typeof(BookWithDetailsDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<BookWithDetailsDto>> GetBookWithDetailsById([Required] int id)
        {
            if (id <= 0)
                return BadRequest("Invalid book ID.");

            var book = await _bookRepository.GetBookWithDetailsByIdAsync(id);
            if (book == null)
                return NotFound($"Book with ID {id} was not found.");

            return Ok(book.ToBookWithDetailsDto());
        }

        /// <summary>
        /// Searches for books by title or partial name.
        /// </summary>
        /// <param name="searchString">The book title or keyword to search for.</param>
        /// <returns>A list of matching books with details.</returns>
        [HttpGet("bookName")]
        [ProducesResponseType(typeof(IEnumerable<BookWithDetailsDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<BookWithDetailsDto>>> GetBooksWithDetailsSearchString([Required] string searchString)
        {
            if (string.IsNullOrWhiteSpace(searchString))
                return BadRequest("Search string cannot be empty.");

            var books = await _bookRepository.GetBookWithDetailsByNameAsync(searchString);
            return Ok(books.Select(book => book.ToBookWithDetailsDto()));
        }
    }
}
