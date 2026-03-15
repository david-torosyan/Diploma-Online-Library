using Library.DAL.IRepositories;
using Library.DAL.Models;
using LibraryAPI.Models;
using LibraryAPI.Services.IServices;
using System.Security.Claims;

namespace LibraryAPI.Services;

public class ReviewService : IReviewService
{
    private readonly IUnitOfWork _unitOfWork;
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly ILogger<ReviewService> _logger;

    public ReviewService(
        IUnitOfWork unitOfWork,
        IHttpContextAccessor httpContextAccessor,
        ILogger<ReviewService> logger)
    {
        _unitOfWork = unitOfWork;
        _httpContextAccessor = httpContextAccessor;
        _logger = logger;
    }

    public async Task<Review> UpsertReviewAsync(int bookId, UpsertReviewDto reviewDto)
    {
        var userId = _httpContextAccessor
            .HttpContext?
            .User?
            .FindFirst(ClaimTypes.NameIdentifier)?.Value
            ?? _httpContextAccessor.HttpContext?.User?.FindFirst(ClaimTypes.Name)?.Value
            ?? _httpContextAccessor.HttpContext?.User?.FindFirst("sub")?.Value;

        if (string.IsNullOrWhiteSpace(userId))
            throw new UnauthorizedAccessException("User is not authenticated.");

        if (reviewDto is null)
            throw new ArgumentNullException(nameof(reviewDto));

        var normalizedContent = reviewDto.Content.Trim();
        if (string.IsNullOrWhiteSpace(normalizedContent))
            throw new ArgumentException("Review comment cannot be empty.");

        var book = await _unitOfWork.Books.GetByIdAsync(bookId);
        if (book is null)
            throw new KeyNotFoundException($"Book with ID {bookId} was not found.");

        var existingReview = await _unitOfWork.Reviews.GetUserReviewAsync(userId, bookId);

        if (existingReview is null)
        {
            existingReview = new Review
            {
                ApplicationUserId = userId,
                BookId = bookId,
                Content = normalizedContent,
                Rating = reviewDto.Rating,
                CreatedAt = DateTime.UtcNow
            };

            await _unitOfWork.Reviews.AddAsync(existingReview);
            _logger.LogInformation("Review created for book {BookId} by user {UserId}", bookId, userId);
        }
        else
        {
            existingReview.Content = normalizedContent;
            existingReview.Rating = reviewDto.Rating;
            _unitOfWork.Reviews.Update(existingReview);
            _logger.LogInformation("Review updated for book {BookId} by user {UserId}", bookId, userId);
        }

        await _unitOfWork.CommitAsync();

        return await _unitOfWork.Reviews.GetUserReviewAsync(userId, bookId)
            ?? existingReview;
    }
}
