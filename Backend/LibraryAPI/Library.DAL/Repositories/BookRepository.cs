using Library.DAL.Data;
using Library.DAL.IRepositories;
using Library.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Repositories;

public class BookRepository(ApplicationDbContext context) : BaseRepository<Book>(context), IBookRepository
{
    public async Task<IEnumerable<Book>> GetByCategoryAsync(string category) =>
        await _dbSet
           .Include(b => b.Category)
           .Include(b => b.Author)
           .Where(b => b.Category.Name == category && b.IsApproved == true)
           .ToListAsync();

    public async Task<Book> GetBookWithDetailsByIdAsync(int bookId) =>
        await _dbSet
           .Include(b => b.Author)
           .Include(b => b.Category)
           .Include(b => b.Reviews)
           .Include(b => b.Favorites)
           .FirstOrDefaultAsync(b => b.Id == bookId);

    public async Task<IEnumerable<Book>> GetBookWithDetailsByNameAsync(string searchString) =>
     await _dbSet
           .Include(b => b.Author)
           .Include(b => b.Category)
           .Include(b => b.Reviews)
           .Include(b => b.Favorites)
           .Where(b => b.IsApproved &&
                       (b.Title.ToLower().StartsWith(searchString.ToLower()) ||
                        b.Title.ToLower().Contains(searchString.ToLower())))
           .Distinct()
           .Take(4)
           .ToListAsync();

    public async Task<IEnumerable<Book>> GetUnApprovedBooksAsync() =>
          await _dbSet
            .Include(b => b.Author)
            .Include(b => b.Category)
            .Where(b => b.IsApproved == false)
            .ToListAsync();
}
