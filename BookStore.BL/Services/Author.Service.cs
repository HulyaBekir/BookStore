using BookStore.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Services

{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorService _authorService;

        public AuthorService(IAuthorService authorService)
        {
            _authorService = authorService;
        }

        void SetAuthorService(IAuthorService authorService)
        {

        }
        
        public List<Author> GetAll()
        {

        }
    }

}
