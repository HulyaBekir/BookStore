using BookStore.DL.Interfaces;
using BookStore.DL.MemoryDb;
using BookStore.Users.Models;

namespace BookStore.DL.Reconstruction
{
    public class AuthorRepository : IAuthorRepository
    {
        public void Add(Author author)
        {
            InMemoryDb.AuthorData.Add(author);
        }

        public List<Author> GetAll()
        {
            return InMemoryDb.AuthorData;
        }

        public Author GetById(int id)
        {
            return InMemoryDb.AuthorData.First(a => a.Id == id);
        }

        public void Remove(int id)
        {
            var author = GetById(id);
            InMemoryDb.AuthorData.Remove(author);
        }
    }
}
