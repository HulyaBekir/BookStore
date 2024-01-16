using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.Models;

namespace BookStore.BL.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;

        public BookService(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }

        public Book GetById(int id)
        {
            return _bookRepository.GetById(id);
        }

        public void Add(Book book)
        {
            _bookRepository.Add(book);
        }

        public void Remove(int id)
        {
            _bookRepository.Remove(id);
        }

        public List<Book> GetAll()
        {
            return _bookRepository.GetAll();
        }

        public List<Book> GetAllByAuthorId(int id)
        {
            return _bookRepository.GetAllByAuthorId(id);
        }

        public int TestCalculation(int number)
        {
            var books = _bookRepository.GetAll();
           
            return books.Count() + number;
            

        }
        
    }
}

