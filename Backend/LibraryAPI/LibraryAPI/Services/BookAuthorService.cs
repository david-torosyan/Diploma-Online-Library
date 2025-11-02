using Library.DAL.IRepositories;
using Library.DAL.Models;
using LibraryAPI.Models;
using LibraryAPI.Services.IServices;

namespace LibraryAPI.Services;

public class BookAuthorService : IBookAuthorService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<BookAuthorService> _logger;

    public BookAuthorService(IUnitOfWork unitOfWork, ILogger<BookAuthorService> logger)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
    }

    /// <summary>
    /// Adds a book and its author if the author does not exist.
    /// </summary>
    /// <param name="addBookDto">Book creation data.</param>
    /// <returns>The newly created book ID.</returns>
    public async Task<int> AddBookWithAuthorAsync(AddBookDto addBookDto)
    {
        try
        {
            if (addBookDto == null)
                throw new ArgumentNullException(nameof(addBookDto), "Book data cannot be null.");

            // 🔹 Step 1: Ensure author exists
            var author = await _unitOfWork.Authors.GetAuthorByNameAsync(addBookDto.AuthorName);
            if (author == null)
            {
                author = new Author { FullName = addBookDto.AuthorName };

                await _unitOfWork.Authors.AddAsync(author);
                await _unitOfWork.CommitAsync();

                _logger.LogInformation("Created new author: {AuthorName}", author.FullName);
            }

            // 🔹 Step 2: Create new book entity
            var book = new Book
            {
                Title = addBookDto.Title,
                CategoryId = addBookDto.CategoryId,
                Description = addBookDto.Description,
                ISBN = addBookDto.ISBN,
                PublishedDate = addBookDto.PublishedDate,
                BookURL = addBookDto.BookUrl,
                ImageURL = addBookDto.ImageUrl,
                AuthorId = author.Id
            };

            // 🔹 Step 3: Save to database
            await _unitOfWork.Books.AddAsync(book);
            await _unitOfWork.CommitAsync();

            _logger.LogInformation("Book '{Title}' successfully added with ID {BookId}", book.Title, book.Id);

            return book.Id;
        }
        catch (ArgumentNullException ex)
        {
            _logger.LogWarning(ex, "Invalid input when adding book.");
            throw; // Let controller handle this (400 Bad Request)
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while adding book '{Title}'.", addBookDto?.Title);
            throw new ApplicationException("An unexpected error occurred while adding the book. Please try again later.", ex);
        }
    }
}
