using Library.DAL.Data;
using Library.DAL.IRepositories;
using Library.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Repositories;

public class ReviewRepository(ApplicationDbContext context) : BaseRepository<Review>(context), IReviewRepository
{
    public async Task<IEnumerable<Review>> GetBookReviewsAsync(int bookId) =>
        await _dbSet
               .Include(r => r.User)
               .Where(r => r.BookId == bookId)
               .ToListAsync();
}
