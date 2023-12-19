using BookStore.Models;
using BookStore.Users.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.BL.Interfaces
{
    public interface IBookService
    {
        List<Book> GetAll();

        Book GetById(int id);

        void Add(Book book);

        void Remove(int id);
    }
}
