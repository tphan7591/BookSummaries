using System;
using System.Collections.Generic;
using System.Linq;

namespace Summaries.Data
{
    public class BookService : IBookService
    {
        public void AddBook(Book newBook)
        {
            Data.Books.Add(newBook);
        }

        public void DeleteBook(int id)
        {
            var book = Data.Books.FirstOrDefault(n => n.Id == id);
            Data.Books.Remove(book);
        }

        public List<Book> GetAllBooks()
        {
            return Data.Books.ToList();
        }

        public Book GetBookId(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(int id, Book newBook)
        {
            throw new NotImplementedException();
        }
    }
}