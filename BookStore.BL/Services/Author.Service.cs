using BookStore.BL.Interfaces;
using BookStore.DL.Interfaces;
using BookStore.Users.Models;

namespace BookStore.BL.Services

{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _autorRepository;

        public AuthorService(IAuthorRepository autorRepository)
        {
            _autorRepository = autorRepository;
        }

        public Author GetById(int id)
        {
            return _autorRepository.GetById(id);
        }

        public void Add(Author author)
        {
            _autorRepository.Add(author);
        }

        public void Remove(int id)
        {
            _autorRepository.Remove(id);
        }

        public List<Author> GetAll()
        {
            return _autorRepository.GetAll();
        }
    }

}
