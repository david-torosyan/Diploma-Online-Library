namespace Library.DAL.IRepositories;

public interface IUnitOfWork
{
    IAuthorRepository Authors { get; }
    IBookRepository Books { get; }
    ICategoryRepository Categories { get; }
    IFavoriteRepository Favorites { get; }
    IReviewRepository Reviews { get; }
    Task CommitAsync();
}
