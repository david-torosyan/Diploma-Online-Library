using Library.DAL.Models;

namespace Library.DAL.IRepositories;

public interface IBookRepository : IBaseRepository<Book>
{
    Task<Book> GetBookWithDetailsByIdAsync(int bookId);
    Task<IEnumerable<Book>> GetBookWithDetailsByNameAsync(string bookName);
    Task<IEnumerable<Book>> GetByCategoryAsync(string category);
    Task<(IEnumerable<Book> Books, int TotalCount)> BrowseApprovedAsync(
        string? query,
        string? category,
        double? minRating,
        int? maxPages,
        string? sortBy,
        int page,
        int pageSize);
    Task<IEnumerable<Book>> GetUnApprovedBooksAsync();
    Task<IEnumerable<Book>> GetFeaturedAsync(int limit);
    Task<IEnumerable<Book>> GetMostRatedAsync(int limit);
    Task<IEnumerable<Book>> GetNewArrivalsAsync(int limit);
    Task<IEnumerable<Book>> GetRelatedAsync(int bookId, int limit);
    Task<IEnumerable<string>> GetTitleSuggestionsAsync(string query, int limit);
}