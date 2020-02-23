using System.Collections.Generic;
using System.Threading.Tasks;
using BookStoreApi.Domain.Models;

namespace BookStoreApi.Services
{
    public interface IBookService
    {
         //Task<IEnumerable<Book>> GetAllBooksByName(string bookName);

         Task<Book> CreateBook(Book book);

         Task<bool> DeleteBook(int id);

        
         Task<Book> UpdateBook(Book book);

         Task<Book> GetBookById(int? id);
         

    }
}