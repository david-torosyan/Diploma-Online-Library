using Library.DAL.Models;

namespace LibraryAPI.Models;

public class BookWithDetailsDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string ISBN { get; set; }
    public int Pages { get; set; }
    public DateTime PublishedDate { get; set; }
    public string Description { get; set; }
    public int AuthorId { get; set; }
    public string AuthorFullName { get; set; }
    public int CategoryId { get; set; }
    public string CategoryName { get; set; }
    public string BookURL { get; set; }
    public string ImageURL { get; set; }

    public ICollection<FavoriteDto> Favorites { get; set; }
    public ICollection<ReviewDto> Reviews { get; set; }
}
