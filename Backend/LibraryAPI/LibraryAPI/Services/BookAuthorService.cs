using Library.DAL.IRepositories;
using Library.DAL.Models;
using Library.DAL.Repositories;
using LibraryAPI.Models;
using LibraryAPI.Services.IServices;
using System.Net;
using System.Security.Claims;

namespace LibraryAPI.Services;

public class BookAuthorService : IBookAuthorService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<BookAuthorService> _logger;
    private readonly IHttpContextAccessor _httpContextAccessor;

    public BookAuthorService(
        IUnitOfWork unitOfWork,
        ILogger<BookAuthorService> logger,
        IHttpContextAccessor httpContextAccessor)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
        _httpContextAccessor = httpContextAccessor;
    }

    public async Task CheckBookInMyFavoritesAsync(int bookId, bool isFavorite)
    {
        try
        {
            var userId = _httpContextAccessor
                .HttpContext?
                .User?
                .FindFirst(ClaimTypes.NameIdentifier)?
                .Value;

            if (string.IsNullOrEmpty(userId))
                throw new UnauthorizedAccessException("User is not authenticated.");

            var book = await _unitOfWork.Books.GetByIdAsync(bookId);
            if (book == null)
                throw new KeyNotFoundException($"Book with ID {bookId} not found.");

            var alreadyFavorite = await _unitOfWork.Favorites
                .IsFavoriteAsync(userId, bookId);

            if (alreadyFavorite)
            {
                if (!isFavorite)
                {
                    var userFavorite = await _unitOfWork.Favorites.GetFavoriteAsync(userId, bookId);
                    if (userFavorite != null)
                    {
                        _unitOfWork.Favorites.Delete(userFavorite);
                        await _unitOfWork.CommitAsync();
                        _logger.LogInformation("Book {BookId} removed from favorites for user {UserId}", bookId, userId);
                    }

                    return;
                }
                else
                {
                    _logger.LogInformation("Book {BookId} already in favorites for user {UserId}", bookId, userId);
                    return;
                }
            }

            var favorite = new Favorite
            {
                ApplicationUserId = userId,
                BookId = bookId
            };

            await _unitOfWork.Favorites.AddAsync(favorite);
            await _unitOfWork.CommitAsync();

            _logger.LogInformation("Book {BookId} added to favorites for user {UserId}", bookId, userId);
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error adding book {BookId} to favorites.", bookId);
            throw;
        }
    }

    public async Task<int> AddBookWithAuthorAsync(AddBookDto addBookDto)
    {
        try
        {
            var userId = _httpContextAccessor
                .HttpContext?
                .User?
                .FindFirst(ClaimTypes.NameIdentifier)?
                .Value;
            
            if (addBookDto == null)
                throw new ArgumentNullException(nameof(addBookDto), "Book data cannot be null.");

            var author = await _unitOfWork.Authors.GetAuthorByNameAsync(addBookDto.AuthorName);
            if (author == null)
            {
                author = new Author { FullName = addBookDto.AuthorName };

                await _unitOfWork.Authors.AddAsync(author);
                await _unitOfWork.CommitAsync();

                _logger.LogInformation("Created new author: {AuthorName}", author.FullName);
            }

            var book = new Book
            {
                Title = addBookDto.Title,
                CategoryId = addBookDto.CategoryId,
                Description = addBookDto.Description ?? string.Empty,
                ISBN = addBookDto.ISBN ?? string.Empty,
                PublishedDate = addBookDto.PublishedDate.Date,
                BookURL = addBookDto.BookUrl,
                ImageURL = addBookDto.ImageUrl ?? string.Empty,
                AuthorId = author.Id,
                IsApproved = false
            };

            await _unitOfWork.Books.AddAsync(book);
            await _unitOfWork.CommitAsync();
            _logger.LogInformation("Book '{Title}' successfully added with ID {BookId}", book.Title, book.Id);

            var favorite = new Favorite
            {
                ApplicationUserId = userId,
                BookId = book.Id
            };
            await _unitOfWork.Favorites.AddAsync(favorite);
            await _unitOfWork.CommitAsync();

            return book.Id;
        }
        catch (ArgumentNullException ex)
        {
            _logger.LogWarning(ex, "Invalid input when adding book.");
            throw;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while adding book '{Title}'.", addBookDto?.Title);
            throw new ApplicationException("An unexpected error occurred while adding the book. Please try again later.", ex);
        }
    }

    public async Task<IEnumerable<Book>> GetMyFavoriteBooksAsync()
    {
        try
        {
            var userId = _httpContextAccessor
                .HttpContext?
                .User?
                .FindFirst(ClaimTypes.NameIdentifier)?
                .Value;

            if (string.IsNullOrEmpty(userId))
                throw new UnauthorizedAccessException("User is not authenticated.");

            var favoriteBooks = await _unitOfWork.Favorites.GetUserFavoritesAsync(userId);

            return [.. favoriteBooks.Select(f => f.Book)];
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving favorite books for current user.");
            throw;
        }
    }

    public Task<IEnumerable<Book>> GetAllUnApprovedBooks()
    {
        try
        {
            return _unitOfWork.Books.GetUnApprovedBooksAsync();
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error retrieving unapproved books.");
            throw;
        }
    }

    public async Task ApproveBookById(int id)
    {
        var book = await _unitOfWork.Books.GetByIdAsync(id);
        if (book == null)
            throw new KeyNotFoundException($"Book with ID {id} not found.");

        book.IsApproved = true;

        await _unitOfWork.CommitAsync();
    }
}
