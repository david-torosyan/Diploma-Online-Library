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
           .Where(b => b.Category.Name == category)
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
            .Where(b => b.Title.StartsWith(searchString) || b.Title.Contains(searchString))
            .Distinct()
            .Take(4)
            .ToListAsync();
}
