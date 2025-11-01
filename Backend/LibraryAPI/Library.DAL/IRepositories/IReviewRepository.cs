using Library.DAL.Models;

namespace Library.DAL.IRepositories;

public interface IReviewRepository : IBaseRepository<Review>
{
    Task<IEnumerable<Review>> GetBookReviewsAsync(int bookId);
}

