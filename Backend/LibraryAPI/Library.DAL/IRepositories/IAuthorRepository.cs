using Library.DAL.Models;

namespace Library.DAL.IRepositories;

public interface IAuthorRepository : IBaseRepository<Author>
{
    Task<Author> GetAuthorWithBooksAsync(int authorId);
}

