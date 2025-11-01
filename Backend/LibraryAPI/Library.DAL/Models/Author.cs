namespace Library.DAL.Models;

public class Author
{
    public int Id { get; set; }
    public string FullName { get; set; }

    // Navigation property
    public ICollection<Book> Books { get; set; }
}
