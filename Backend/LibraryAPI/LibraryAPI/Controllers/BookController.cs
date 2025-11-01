using Library.DAL.IRepositories;
using Library.DAL.Models;
using LibraryAPI.Mappers;
using LibraryAPI.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace LibraryAPI.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _bookRepository;
        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        [HttpGet("category")]
        public async Task<ActionResult<IEnumerable<BookDto>>> GetBooksByCategory([Required] string category) =>
            Ok((await _bookRepository.GetByCategoryAsync(category))
                                     .Select(book => book.ToBookDto()));

        [HttpGet("id")]
        public async Task<ActionResult<BookWithDetailsDto>> GetBookWithDetailsById([Required] int id) =>
            Ok((await _bookRepository.GetBookWithDetailsByIdAsync(id)).ToBookWithDetailsDto());

        [HttpGet("bookName")]
        public async Task<ActionResult<IEnumerable<BookWithDetailsDto>>> GetBooksWithDetailsSearchString([Required] string searchString) =>
            Ok((await _bookRepository.GetBookWithDetailsByNameAsync(searchString))
                                     .Select(book => book.ToBookWithDetailsDto()));
    }
}
