using BookStore.BL.Interfaces;
using BookStore.Models.Models.Requests;
using BookStore.Models.Models.Responses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Services
{
    public class LibraryService : ILibraryServices
    {
        private readonly IAuthorService _authorService;
        private readonly IBookService _bookService;
        public LibraryService(IAuthorService authorService, IBookService bookService)
        {
            _authorService = authorService;
            _bookService = bookService;
        }

        public GetBooksByAuthorResponses? GetBooksByAuthor(GetBookByAuthorRequest request)
        {
            var books = _bookService.GetAllByAuthorId(request.Id);

            if (books.Count > 0)
            {
                var response = new GetBooksByAuthorResponses()
                {
                    Author = _authorService.GetById(request.Id),
                    Books = books.Where(b => b.ReleaseDate >= request.AfterDate).ToList()

                };

                return response;

            }

            return null;
        }

    }
}
