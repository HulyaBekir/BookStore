﻿using BookStore.Users.Models;

namespace BookStore.DL.Interfaces
{
    public interface IAuthorRepository
    {
        List<Author> GetAll();

        Author GetById(int id);

        void Add(Author author);

        void Remove(int id);
    }
}
