using Library.DAL.Models;
using LibraryAPI.Models;

namespace LibraryAPI.Services.IServices;

public interface IBookAuthorService
{
    Task CheckBookInMyFavoritesAsync(int bookId, bool isFavorite);
    Task<int> AddBookWithAuthorAsync(AddBookDto addBookDto);
    Task<IEnumerable<Book>> GetMyFavoriteBooksAsync();
}
