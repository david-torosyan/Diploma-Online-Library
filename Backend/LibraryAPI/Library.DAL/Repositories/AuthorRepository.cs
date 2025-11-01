using Library.DAL.Data;
using Library.DAL.IRepositories;
using Library.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Repositories;

public class AuthorRepository(ApplicationDbContext context) : BaseRepository<Author>(context), IAuthorRepository
{
    public async Task<Author> GetAuthorWithBooksAsync(int authorId) =>
        await _dbSet
            .Include(a => a.Books)
            .FirstOrDefaultAsync(a => a.Id == authorId);
}
