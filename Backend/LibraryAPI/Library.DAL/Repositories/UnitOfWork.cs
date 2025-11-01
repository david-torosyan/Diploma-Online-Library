using Library.DAL.Data;
using Library.DAL.IRepositories;

namespace Library.DAL.Repositories;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    public IAuthorRepository Authors { get; private set; }
    public IBookRepository Books { get; private set; }
    public ICategoryRepository Categories { get; private set; }
    public IFavoriteRepository Favorites { get; private set; }
    public IReviewRepository Reviews { get; private set; }

    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;

        // Initialize repositories
        Authors = new AuthorRepository(_context);
        Books = new BookRepository(_context);
        Categories = new CategoryRepository(_context);
        Favorites = new FavoriteRepository(_context);
        Reviews = new ReviewRepository(_context);
    }

    public async Task CommitAsync() =>
        await _context.SaveChangesAsync();
}
