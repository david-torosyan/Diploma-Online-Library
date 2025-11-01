using Library.DAL.Models;

namespace Library.DAL.IRepositories;

public interface IBookRepository : IBaseRepository<Book>
{
    Task<Book> GetBookWithDetailsByIdAsync(int bookId);
    Task<IEnumerable<Book>> GetBookWithDetailsByNameAsync(string bookName);
    Task<IEnumerable<Book>> GetByCategoryAsync(string category);
}