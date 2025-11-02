using LibraryAPI.Models;

namespace LibraryAPI.Services.IServices;

public interface IBookAuthorService
{
    Task<int> AddBookWithAuthorAsync(AddBookDto addBookDto);
}
