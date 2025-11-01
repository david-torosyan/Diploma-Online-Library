using Library.DAL.Models;

namespace Library.DAL.IRepositories;

public interface ICategoryRepository : IBaseRepository<Category>
{
    Task<Category> GetCategoryWithBooksAsync(int categoryId);
}
