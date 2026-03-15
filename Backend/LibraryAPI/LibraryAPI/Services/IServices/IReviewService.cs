using Library.DAL.Models;
using LibraryAPI.Models;

namespace LibraryAPI.Services.IServices;

public interface IReviewService
{
    Task<Review> UpsertReviewAsync(int bookId, UpsertReviewDto reviewDto);
}
