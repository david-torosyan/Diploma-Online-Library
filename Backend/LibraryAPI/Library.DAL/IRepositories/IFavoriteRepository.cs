using Library.DAL.Models;

namespace Library.DAL.IRepositories;

public interface IFavoriteRepository : IBaseRepository<Favorite>
{
    Task<Favorite> GetFavoriteAsync(string userId, int bookId);
    Task<IEnumerable<Favorite>> GetUserFavoritesAsync(string userId);
    Task<bool> IsFavoriteAsync(string userId, int bookId);
}
