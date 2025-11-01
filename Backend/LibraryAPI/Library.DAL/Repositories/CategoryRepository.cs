using Library.DAL.Data;
using Library.DAL.IRepositories;
using Library.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Repositories;

public class CategoryRepository(ApplicationDbContext context) : BaseRepository<Category>(context), ICategoryRepository
{
    public async Task<Category> GetCategoryWithBooksAsync(int categoryId) =>
        await _dbSet
           .Include(c => c.Books)
           .FirstOrDefaultAsync(c => c.Id == categoryId);
}
