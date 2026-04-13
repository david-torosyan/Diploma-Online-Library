using Library.DAL.IRepositories;
using Library.DAL.Models;
using LibraryAPI.Models;
using LibraryAPI.Services.IServices;
using System.Security.Claims;

namespace LibraryAPI.Services;

public class BookAuthorService : IBookAuthorService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly ILogger<BookAuthorService> _logger;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IWebHostEnvironment _environment;
    private readonly IHttpClientFactory _httpClientFactory;

    private static readonly string[] AllowedImageExtensions = [".jpg", ".jpeg", ".png", ".webp", ".gif", ".bmp"];
    private static readonly string[] AllowedPdfExtensions = [".pdf"];

    public BookAuthorService(
        IUnitOfWork unitOfWork,
        ILogger<BookAuthorService> logger,
        IHttpContextAccessor httpContextAccessor,
        IWebHostEnvironment environment,
        IHttpClientFactory httpClientFactory)
    {
        _unitOfWork = unitOfWork;
        _logger = logger;
        _httpContextAccessor = httpContextAccessor;
        _environment = environment;
        _httpClientFactory = httpClientFactory;
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

            var hasBookUrl = !string.IsNullOrWhiteSpace(addBookDto.BookUrl);
            var hasBookFile = addBookDto.BookFile is { Length: > 0 };
            var hasImageUrl = !string.IsNullOrWhiteSpace(addBookDto.ImageUrl);
            var hasImageFile = addBookDto.ImageFile is { Length: > 0 };

            if (!hasBookUrl && !hasBookFile)
                throw new ArgumentException("Provide either a book URL or a PDF file.");

            if (!hasImageUrl && !hasImageFile)
                throw new ArgumentException("Provide either an image URL or an image file.");

            var bookPath = hasBookFile
                    ? await SaveUploadedFileAsync(addBookDto.BookFile!, "pdfs", AllowedPdfExtensions)
                    : addBookDto.BookUrl!;

            var imagePath = hasImageFile
                    ? await SaveUploadedFileAsync(addBookDto.ImageFile!, "pictures", AllowedImageExtensions)
                    : addBookDto.ImageUrl!;

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
                ISBN = GenerateIsbn13(),
                PublishedDate = addBookDto.PublishedDate?.Date ?? DateTime.UtcNow.Date,
                BookURL = bookPath,
                ImageURL = imagePath,
                AuthorId = author.Id,
                IsApproved = false
            };

            await _unitOfWork.Books.AddAsync(book);
            await _unitOfWork.CommitAsync();
            _logger.LogInformation("Book '{Title}' successfully added with ID {BookId}", book.Title, book.Id);

            if (!string.IsNullOrWhiteSpace(userId))
            {
                var favorite = new Favorite()
                {
                    ApplicationUserId = userId,
                    BookId = book.Id
                };
                await _unitOfWork.Favorites.AddAsync(favorite);
                await _unitOfWork.CommitAsync();
            }

            return book.Id;
        }
        catch (ArgumentNullException ex)
        {
            _logger.LogWarning(ex, "Invalid input when adding book.");
            throw;
        }
        catch (ArgumentException ex)
        {
            _logger.LogWarning(ex, "Validation error while adding book.");
            throw;
        }
        catch (HttpRequestException ex)
        {
            _logger.LogWarning(ex, "Failed to fetch file from URL while adding book.");
            throw new ArgumentException("Failed to download media from the provided URL. Please check the link and try again.");
        }
        catch (IOException ex)
        {
            _logger.LogError(ex, "Failed to save uploaded media while adding book.");
            throw new InvalidOperationException("Failed to save uploaded files. Please try again.");
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error occurred while adding book '{Title}'.", addBookDto?.Title);
            throw;
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

    public async Task DeclineBookById(int id)
    {
        var book = await _unitOfWork.Books.GetByIdAsync(id);
        if (book == null)
            throw new KeyNotFoundException($"Book with ID {id} not found.");

        if (book.IsApproved)
            throw new ArgumentException("Only pending books can be declined.");

        DeleteLocalMediaFile(book.BookURL);
        DeleteLocalMediaFile(book.ImageURL);

        _unitOfWork.Books.Delete(book);
        await _unitOfWork.CommitAsync();
    }

    private async Task<string> SaveUploadedFileAsync(IFormFile file, string subFolder, string[] allowedExtensions)
    {
        var extension = Path.GetExtension(file.FileName)?.ToLowerInvariant();
        if (string.IsNullOrWhiteSpace(extension))
            extension = GetExtensionFromContentType(file.ContentType);

        if (string.IsNullOrWhiteSpace(extension) || !allowedExtensions.Contains(extension))
            throw new ArgumentException($"Unsupported file extension '{extension}'.");

        var mediaRoot = EnsureMediaFolder(subFolder);
        var safeFileName = $"{Guid.NewGuid():N}{extension}";
        var filePath = Path.Combine(mediaRoot, safeFileName);

        await using var stream = new FileStream(filePath, FileMode.Create);
        await file.CopyToAsync(stream);

        return $"/media/{subFolder}/{safeFileName}";
    }

    private async Task<string> DownloadAndSaveFromUrlAsync(
        string sourceUrl,
        string subFolder,
        string[] allowedExtensions,
        string fallbackExtension)
    {
        if (!Uri.TryCreate(sourceUrl, UriKind.Absolute, out var uri) ||
            (uri.Scheme != Uri.UriSchemeHttp && uri.Scheme != Uri.UriSchemeHttps))
        {
            throw new ArgumentException("Invalid URL provided.");
        }

        var extension = Path.GetExtension(uri.AbsolutePath)?.ToLowerInvariant();
        if (string.IsNullOrWhiteSpace(extension) || !allowedExtensions.Contains(extension))
            extension = fallbackExtension;

        if (!allowedExtensions.Contains(extension))
            throw new ArgumentException("Unsupported file type provided by URL.");

        var client = _httpClientFactory.CreateClient();
        using var response = await client.GetAsync(uri, HttpCompletionOption.ResponseHeadersRead);
        response.EnsureSuccessStatusCode();

        var mediaRoot = EnsureMediaFolder(subFolder);
        var safeFileName = $"{Guid.NewGuid():N}{extension}";
        var filePath = Path.Combine(mediaRoot, safeFileName);

        await using var source = await response.Content.ReadAsStreamAsync();
        await using var destination = new FileStream(filePath, FileMode.Create);
        await source.CopyToAsync(destination);

        return $"/media/{subFolder}/{safeFileName}";
    }

    private string EnsureMediaFolder(string subFolder)
    {
        var root = Path.Combine(_environment.ContentRootPath, "Media", subFolder);
        if (!Directory.Exists(root))
            Directory.CreateDirectory(root);

        return root;
    }

    private void DeleteLocalMediaFile(string? url)
    {
        if (string.IsNullOrWhiteSpace(url) || !url.StartsWith("/media/", StringComparison.OrdinalIgnoreCase))
            return;

        var relativePath = url.TrimStart('/').Replace('/', Path.DirectorySeparatorChar);
        var fullPath = Path.Combine(_environment.ContentRootPath, relativePath);

        if (File.Exists(fullPath))
            File.Delete(fullPath);
    }

    private static string? GetExtensionFromContentType(string? contentType)
    {
        return contentType?.ToLowerInvariant() switch
        {
            "application/pdf" => ".pdf",
            "image/jpeg" => ".jpg",
            "image/jpg" => ".jpg",
            "image/png" => ".png",
            "image/webp" => ".webp",
            "image/gif" => ".gif",
            "image/bmp" => ".bmp",
            _ => null
        };
    }

    private static string GenerateIsbn13()
    {
        var randomDigits = Random.Shared.NextInt64(100_000_000, 999_999_999).ToString();
        var firstTwelve = $"978{randomDigits}";

        var sum = 0;
        for (var i = 0; i < firstTwelve.Length; i++)
        {
            var digit = firstTwelve[i] - '0';
            sum += i % 2 == 0 ? digit : digit * 3;
        }

        var checkDigit = (10 - (sum % 10)) % 10;
        return $"{firstTwelve}{checkDigit}";
    }
}
