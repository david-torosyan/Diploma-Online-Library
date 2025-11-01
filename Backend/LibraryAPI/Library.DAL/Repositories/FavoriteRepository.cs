using Library.DAL.Data;
using Library.DAL.IRepositories;
using Library.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Repositories;

public class FavoriteRepository(ApplicationDbContext context) : BaseRepository<Favorite>(context), IFavoriteRepository
{
    public async Task<IEnumerable<Favorite>> GetUserFavoritesAsync(string userId) =>
        await _dbSet
           .Include(f => f.Book)
               .ThenInclude(b => b.Author)
           .Where(f => f.ApplicationUserId == userId)
           .ToListAsync();
}
