using Library.DAL.Data;
using Library.DAL.IRepositories;
using Library.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Repositories;

public class FavoriteRepository(ApplicationDbContext context) : BaseRepository<Favorite>(context), IFavoriteRepository
{
    public async Task<Favorite> GetFavoriteAsync(string userId, int bookId) =>
        await _dbSet.FirstOrDefaultAsync(f => f.ApplicationUserId == userId && f.BookId == bookId);

    public async Task<IEnumerable<Favorite>> GetUserFavoritesAsync(string userId) =>
        await _dbSet
           .Include(f => f.Book)
               .ThenInclude(b => b.Author)
           .Include(f => f.Book)
               .ThenInclude(b => b.Category)
           .Where(f => f.ApplicationUserId == userId)
           .ToListAsync();

    public async Task<bool> IsFavoriteAsync(string userId, int bookId) =>
         await _dbSet.AnyAsync(f => f.ApplicationUserId == userId &&
                               f.BookId == bookId);
}
