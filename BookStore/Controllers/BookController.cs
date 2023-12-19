using BookStore.BL.Interfaces;
using BookStore.BL.Services;
using BookStore.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;
        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        [HttpGet("GetBookById")]

        public Book GetBookById(int id)
        {
            return _bookService.GetById(id);
        }

        [HttpGet("GetAllBooks")]

        public List<Book> GetAllBooks()
        {
            return _bookService.GetAll();
        }

        [HttpPost]

        public void Add([FromBody]Book book)
        {
            _bookService.Add(book);
        }

        [HttpDelete]

        public void Delete(int id)
        {
            _bookService.Remove(id);
        }

        
    }
}
