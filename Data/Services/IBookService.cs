using System.Collections.Generic;
using Summaries.Data;

namespace Summaries.Data
{
    public interface IBookService
    {
        List<Book> GetAllBooks();
        Book GetBookId(int id);
        void UpdateBook(int id, Book newBook);
        void DeleteBook(int id);
        void AddBook(Book newBook);
        
    }
}