using BookStore.DL.Interfaces;
using BookStore.DL.MemoryDb;
using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DL.Repositores
{
    public class BookRepository : IBookRepository
    {
        public void Add(Book book)
        {
            InMemoryDb.BookData.Add(book);
        }

        public List<Book> GetAll()
        {
            return InMemoryDb.BookData;
        }

        public List<Book> GetAllByAuthorId(int id)
        {
            return InMemoryDb.BookData.Where(b => b.AuthorId == id).ToList();

        }

        public Book GetById(int id)
        {
            return InMemoryDb.BookData.First(a => a.Id == id);
        }

        public void Remove(int id)
        {
            var book = GetById(id);
            InMemoryDb.BookData.Remove(book);
        }
    }
}

