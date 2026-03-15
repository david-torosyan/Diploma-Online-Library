using Library.DAL.IRepositories;
using LibraryAPI.Constans;
using LibraryAPI.Mappers;
using LibraryAPI.Models;
using LibraryAPI.Services.IServices;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Route("api/books")]
    public class BookController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IBookAuthorService _bookAuthorService;
        private readonly IReviewService _reviewService;

        public BookController(IUnitOfWork unitOfWork, IBookAuthorService bookAuthorService, IReviewService reviewService)
        {
            _unitOfWork = unitOfWork;
            _bookAuthorService = bookAuthorService;
            _reviewService = reviewService;
        }

        /// <summary>
        /// Retrieves the current user's favorite books.
        /// </summary>
        /// <returns>List of favorite books.</returns>
        [Authorize]
        [HttpGet("my-favorites")]
        [ProducesResponseType(typeof(IEnumerable<BookDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetMyFavoriteBooks()
        {
            var books = await _bookAuthorService.GetMyFavoriteBooksAsync();

            return Ok(books.Select(b => b.ToBookDto()));
        }

        /// <summary>
        /// Adds a book to the current user's favorite books.
        /// </summary>
        /// <param name="bookId">The ID of the book to add.</param>
        /// <returns>Success message.</returns>
        [Authorize]
        [HttpPost("my-favorites/{bookId}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> CheckBookToMyFavorites([Required] int bookId, [FromBody] bool isFavorite)
        {
            if (bookId <= 0)
                return BadRequest("Invalid book ID.");

            await _bookAuthorService.CheckBookInMyFavoritesAsync(bookId, isFavorite);

            return Ok("Book added to favorites.");
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

            var books = await _unitOfWork.Books.GetByCategoryAsync(category);
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

            var book = await _unitOfWork.Books.GetBookWithDetailsByIdAsync(id);
            if (book == null)
                return NotFound($"Book with ID {id} was not found.");

            return Ok(book.ToBookWithDetailsDto());
        }

        /// <summary>
        /// Creates or updates the current user's review for a book.
        /// </summary>
        [Authorize]
        [HttpPost("{bookId:int}/reviews")]
        [ProducesResponseType(typeof(ReviewDto), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(string), StatusCodes.Status404NotFound)]
        public async Task<ActionResult<ReviewDto>> UpsertReview(int bookId, [FromBody] UpsertReviewDto reviewDto)
        {
            if (bookId <= 0)
                return BadRequest("Invalid book ID.");

            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var review = await _reviewService.UpsertReviewAsync(bookId, reviewDto);

            return Ok(review.ToReviewDto());
        }

        /// <summary>
        /// Adds a new book to the library.
        /// </summary>
        /// <param name="bookDto">The book details to create.</param>
        /// <returns>The ID of the newly created book.</returns>
        [Authorize]
        [HttpPost("addBookWithAuthor")]
        [ProducesResponseType(typeof(int), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(string), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<int>> AddBook([FromBody] AddBookDto bookDto)
        {
            if (!ModelState.IsValid)
                return BadRequest("Invalid book data.");

            var newBookId = await _bookAuthorService.AddBookWithAuthorAsync(bookDto);

            return CreatedAtAction(
                nameof(GetBookWithDetailsById),
                new { id = newBookId },
                newBookId
            );
        }

        /// <summary>
        /// Retrieves all books that are pending approval.
        /// </summary>
        /// <remarks>
        /// This endpoint is accessible only to users with the Admin role.
        /// It returns a list of books that have been submitted but not yet approved for publication.
        /// </remarks>
        /// <returns>
        /// Returns a list of <see cref="BookDto"/> representing unapproved books.
        /// </returns>
        [Authorize(Roles = $"{RoleConstans.Admin}, {RoleConstans.Maintainer}")]
        [HttpGet("unapproved")]
        [ProducesResponseType(typeof(IEnumerable<BookDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetUnapprovedBooks()
        {
            var books = await _bookAuthorService.GetAllUnApprovedBooks();

            var result = books.Select(book => book.ToBookWithDetailsDto());

            return Ok(result);
        }

        /// <summary>
        /// Approves a book for publication.
        /// </summary>
        /// <remarks>
        /// This endpoint allows an administrator to approve a book that was previously submitted.
        /// Once approved, the book becomes publicly available.
        /// </remarks>
        /// <param name="id">The ID of the book to approve.</param>
        /// <returns>
        /// Returns 204 NoContent if the book is successfully approved.
        /// Returns 404 if the book is not found.
        /// </returns>
        [Authorize(Roles = $"{RoleConstans.Admin}, {RoleConstans.Maintainer}")]
        [HttpPut("{id}/approve")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(StatusCodes.Status403Forbidden)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> ApproveBook(int id)
        {
            await _bookAuthorService.ApproveBookById(id);

            return Ok();
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

            var books = await _unitOfWork.Books.GetBookWithDetailsByNameAsync(searchString);
            return Ok(books.Select(book => book.ToBookWithDetailsDto()));
        }

        /// <summary>
        /// Returns featured books for the home discovery shelf.
        /// </summary>
        [HttpGet("featured")]
        [ProducesResponseType(typeof(IEnumerable<BookDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetFeaturedBooks([FromQuery] int limit = 10)
        {
            if (limit is <= 0 or > 50)
                return BadRequest("Limit must be between 1 and 50.");

            var books = await _unitOfWork.Books.GetFeaturedAsync(limit);
            return Ok(books.Select(book => book.ToBookDto()));
        }

        /// <summary>
        /// Returns top-rated approved books ordered by average rating.
        /// </summary>
        [HttpGet("most-rated")]
        [ProducesResponseType(typeof(IEnumerable<BookDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetMostRatedBooks([FromQuery] int limit = 10)
        {
            if (limit is <= 0 or > 50)
                return BadRequest("Limit must be between 1 and 50.");

            var books = await _unitOfWork.Books.GetMostRatedAsync(limit);
            return Ok(books.Select(book => book.ToBookDto()));
        }

        /// <summary>
        /// Returns latest approved books ordered by publish date.
        /// </summary>
        [HttpGet("new-arrivals")]
        [ProducesResponseType(typeof(IEnumerable<BookDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetNewArrivals([FromQuery] int limit = 10)
        {
            if (limit is <= 0 or > 50)
                return BadRequest("Limit must be between 1 and 50.");

            var books = await _unitOfWork.Books.GetNewArrivalsAsync(limit);
            return Ok(books.Select(book => book.ToBookDto()));
        }

        /// <summary>
        /// Returns books related to a specific book based on category and engagement.
        /// </summary>
        [HttpGet("{id:int}/related")]
        [ProducesResponseType(typeof(IEnumerable<BookDto>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetRelatedBooks(int id, [FromQuery] int limit = 8)
        {
            if (id <= 0)
                return BadRequest("Invalid book ID.");

            if (limit is <= 0 or > 50)
                return BadRequest("Limit must be between 1 and 50.");

            var books = await _unitOfWork.Books.GetRelatedAsync(id, limit);
            return Ok(books.Select(book => book.ToBookDto()));
        }

        /// <summary>
        /// Returns lightweight title suggestions for search autocomplete.
        /// </summary>
        [HttpGet("search/suggestions")]
        [ProducesResponseType(typeof(IEnumerable<string>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<IEnumerable<string>>> GetSearchSuggestions([FromQuery] string q, [FromQuery] int limit = 6)
        {
            if (string.IsNullOrWhiteSpace(q))
                return BadRequest("Query cannot be empty.");

            if (limit is <= 0 or > 20)
                return BadRequest("Limit must be between 1 and 20.");

            var suggestions = await _unitOfWork.Books.GetTitleSuggestionsAsync(q, limit);
            return Ok(suggestions);
        }
    }
}
