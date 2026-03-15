using Library.DAL.Models;
using LibraryAPI.Models;

namespace LibraryAPI.Mappers;

public static class MapperExtentions
{
    extension(Book book)
    {
        public BookDto ToBookDto() =>
            new()
            {
                Id = book.Id,
                Title = book.Title,
                CategoryId = book.CategoryId,
                CategoryName = book.Category.Name,
                ImageURL = book.ImageURL,
                AverageRating = book.Reviews?.Count > 0
                    ? Math.Round(book.Reviews.Average(r => r.Rating), 1)
                    : 0,
                ReviewsCount = book.Reviews?.Count ?? 0,
            };

        public BookWithDetailsDto ToBookWithDetailsDto() =>
            new()
            {
                Id = book.Id,
                Title = book.Title,
                ISBN = book.ISBN,
                Pages = book.Pages,
                PublishedDate = book.PublishedDate,
                Description = book.Description,
                AuthorId = book.AuthorId,
                AuthorFullName = book.Author.FullName,
                CategoryId = book.CategoryId,
                CategoryName = book.Category.Name,
                BookURL = book.BookURL,
                ImageURL = book.ImageURL,
                AverageRating = book.Reviews?.Count > 0
                    ? Math.Round(book.Reviews.Average(r => r.Rating), 1)
                    : 0,
                ReviewsCount = book.Reviews?.Count ?? 0,
                Favorites = book.Favorites?
                    .Select(_ => new FavoriteDto())
                    .ToList() ?? [],
                Reviews = book.Reviews?
                    .OrderByDescending(r => r.CreatedAt)
                    .Select(r => r.ToReviewDto())
                    .ToList() ?? []
            };
    }

    extension(Review review)
    {
        public ReviewDto ToReviewDto() =>
            new()
            {
                Id = review.Id,
                BookId = review.BookId,
                ApplicationUserId = review.ApplicationUserId,
                ReviewerName = string.Join(
                    " ",
                    new[] { review.User?.FirstName, review.User?.LastName }
                        .Where(value => !string.IsNullOrWhiteSpace(value))) switch
                {
                    { Length: > 0 } fullName => fullName,
                    _ => review.User?.Email ?? "Anonymous reader"
                },
                Content = review.Content,
                Rating = review.Rating,
                CreatedAt = review.CreatedAt
            };
    }

    extension(Category category)
    {
        public CategoryDto ToCategoryDto() =>
            new()
            {
                Id = category.Id,
                Name = category.Name
            };
    }
}
