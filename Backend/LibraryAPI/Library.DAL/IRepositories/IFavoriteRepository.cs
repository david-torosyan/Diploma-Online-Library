using Library.DAL.Models;

namespace Library.DAL.IRepositories;

public interface IFavoriteRepository : IBaseRepository<Favorite>
{
    Task<IEnumerable<Favorite>> GetUserFavoritesAsync(string userId);
}
