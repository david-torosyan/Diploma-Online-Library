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
                ImageURL = book.ImageURL
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
