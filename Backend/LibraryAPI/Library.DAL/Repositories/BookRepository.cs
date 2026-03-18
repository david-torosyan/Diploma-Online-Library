using Library.DAL.Data;
using Library.DAL.IRepositories;
using Library.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Library.DAL.Repositories;

public class BookRepository(ApplicationDbContext context) : BaseRepository<Book>(context), IBookRepository
{
    // Phase-4 backend expansion: these methods power discovery sections and
    // search suggestions while keeping all existing endpoints untouched.
    public async Task<(IEnumerable<Book> Books, int TotalCount)> BrowseApprovedAsync(
        string? query,
        string? category,
        double? minRating,
        int? maxPages,
        string? sortBy,
        int page,
        int pageSize)
    {
        var normalizedQuery = query?.Trim();
        var normalizedCategory = category?.Trim();

        var filteredQuery = _dbSet
            .AsNoTracking()
            .Include(b => b.Category)
            .Include(b => b.Reviews)
            .Where(b => b.IsApproved)
            .AsQueryable();

        if (!string.IsNullOrWhiteSpace(normalizedQuery))
        {
            var search = normalizedQuery.ToLower();
            filteredQuery = filteredQuery.Where(book =>
                book.Title.ToLower().Contains(search) ||
                book.Description.ToLower().Contains(search));
        }

        if (!string.IsNullOrWhiteSpace(normalizedCategory))
        {
            var categoryFilter = normalizedCategory.ToLower();
            filteredQuery = filteredQuery.Where(book =>
                book.Category.Name.ToLower() == categoryFilter);
        }

        if (maxPages.HasValue)
        {
            filteredQuery = filteredQuery.Where(book => book.Pages <= maxPages.Value);
        }

        if (minRating.HasValue)
        {
            filteredQuery = filteredQuery.Where(book =>
                book.Reviews.Any() &&
                book.Reviews.Average(review => review.Rating) >= minRating.Value);
        }

        var totalCount = await filteredQuery.CountAsync();

        var orderedQuery = (sortBy ?? string.Empty).Trim().ToLower() switch
        {
            "top-rated" => filteredQuery
                .OrderByDescending(book => book.Reviews.Any() ? book.Reviews.Average(review => review.Rating) : 0)
                .ThenByDescending(book => book.Reviews.Count)
                .ThenBy(book => book.Title),
            "most-reviewed" => filteredQuery
                .OrderByDescending(book => book.Reviews.Count)
                .ThenByDescending(book => book.Reviews.Any() ? book.Reviews.Average(review => review.Rating) : 0)
                .ThenBy(book => book.Title),
            "title" => filteredQuery
                .OrderBy(book => book.Title)
                .ThenByDescending(book => book.Id),
            "relevance" when !string.IsNullOrWhiteSpace(normalizedQuery) => filteredQuery
                .OrderByDescending(book => book.Title.ToLower().StartsWith(normalizedQuery!.ToLower()))
                .ThenByDescending(book => book.Reviews.Count)
                .ThenBy(book => book.Title),
            _ => filteredQuery
                .OrderByDescending(book => book.PublishedDate)
                .ThenByDescending(book => book.Id)
        };

        var books = await orderedQuery
            .Skip((page - 1) * pageSize)
            .Take(pageSize)
            .ToListAsync();

        return (books, totalCount);
    }

    public async Task<IEnumerable<Book>> GetByCategoryAsync(string category) =>
        await _dbSet
           .Include(b => b.Category)
           .Include(b => b.Author)
           .Where(b => b.Category.Name == category && b.IsApproved == true)
           .ToListAsync();

    public async Task<Book> GetBookWithDetailsByIdAsync(int bookId) =>
        await _dbSet
           .Include(b => b.Author)
           .Include(b => b.Category)
           .Include(b => b.Reviews)
                .ThenInclude(r => r.User)
           .Include(b => b.Favorites)
           .FirstOrDefaultAsync(b => b.Id == bookId);

    public async Task<IEnumerable<Book>> GetBookWithDetailsByNameAsync(string searchString) =>
     await _dbSet
           .Include(b => b.Author)
           .Include(b => b.Category)
             .Include(b => b.Reviews)
                .ThenInclude(r => r.User)
           .Include(b => b.Favorites)
           .Where(b => b.IsApproved &&
                       (b.Title.ToLower().StartsWith(searchString.ToLower()) ||
                        b.Title.ToLower().Contains(searchString.ToLower())))
           .Distinct()
           .Take(4)
           .ToListAsync();

    public async Task<IEnumerable<Book>> GetUnApprovedBooksAsync() =>
          await _dbSet
            .Include(b => b.Author)
            .Include(b => b.Category)
            .Where(b => b.IsApproved == false)
            .ToListAsync();

    public async Task<IEnumerable<Book>> GetFeaturedAsync(int limit) =>
        await _dbSet
            .AsNoTracking()
            .Include(b => b.Category)
            .Include(b => b.Reviews)
            .Where(b => b.IsApproved)
            .OrderByDescending(b => b.Favorites.Count)
            .ThenByDescending(b => b.Reviews.Count)
            .ThenByDescending(b => b.Id)
            .Take(limit)
            .ToListAsync();

    public async Task<IEnumerable<Book>> GetMostRatedAsync(int limit) =>
        await _dbSet
            .AsNoTracking()
            .Include(b => b.Category)
            .Include(b => b.Reviews)
            .Where(b => b.IsApproved && b.Reviews.Any())
            .OrderByDescending(b => b.Reviews.Average(r => r.Rating))
            .ThenByDescending(b => b.Reviews.Count)
            .ThenBy(b => b.Title)
            .Take(limit)
            .ToListAsync();

    public async Task<IEnumerable<Book>> GetNewArrivalsAsync(int limit) =>
        await _dbSet
            .AsNoTracking()
            .Include(b => b.Category)
            .Include(b => b.Reviews)
            .Where(b => b.IsApproved)
            .OrderByDescending(b => b.PublishedDate)
            .ThenByDescending(b => b.Id)
            .Take(limit)
            .ToListAsync();

    public async Task<IEnumerable<Book>> GetRelatedAsync(int bookId, int limit)
    {
        var currentBook = await _dbSet
            .AsNoTracking()
            .Where(b => b.Id == bookId)
            .Select(b => new { b.Id, b.CategoryId, b.IsApproved })
            .FirstOrDefaultAsync();

        if (currentBook == null)
            return Enumerable.Empty<Book>();

        return await _dbSet
            .AsNoTracking()
            .Include(b => b.Category)
            .Include(b => b.Reviews)
            .Where(b => b.IsApproved && b.Id != bookId && b.CategoryId == currentBook.CategoryId)
            .OrderByDescending(b => b.Favorites.Count)
            .ThenByDescending(b => b.Reviews.Count)
            .ThenByDescending(b => b.PublishedDate)
            .Take(limit)
            .ToListAsync();
    }

    public async Task<IEnumerable<string>> GetTitleSuggestionsAsync(string query, int limit)
    {
        var normalizedQuery = query.Trim().ToLower();

        return await _dbSet
            .AsNoTracking()
            .Where(b => b.IsApproved && b.Title.ToLower().Contains(normalizedQuery))
            .OrderByDescending(b => b.Title.ToLower().StartsWith(normalizedQuery))
            .ThenByDescending(b => b.Favorites.Count)
            .ThenBy(b => b.Title)
            .Select(b => b.Title)
            .Distinct()
            .Take(limit)
            .ToListAsync();
    }
}
