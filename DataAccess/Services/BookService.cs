using System.Collections.Generic;
using System.Threading.Tasks;
using BookStore.DataAccess.Data;
using BookStoreApi.Domain;
using BookStoreApi.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApi.Services {
    public class BookService : IBookService {
        private readonly BookStoreContext _bookDbContext;

        public BookService (BookStoreContext bookDbContext) {
            _bookDbContext = bookDbContext;
        }

        public async Task<Book> CreateBook (Book book) {

            _bookDbContext.Books.Add (book);
            var saveResult = await _bookDbContext.SaveChangesAsync ();

            return book;

        }

        public async Task<Book> UpdateBook (Book book) {
            _bookDbContext.Update (book);
            var saveResult = await _bookDbContext.SaveChangesAsync ();

            return book;

        }

        public async Task<bool> DeleteBook (int id) {
            var book = await GetBookById (id);
            _bookDbContext.Remove (book);
            var saveResult = await _bookDbContext.SaveChangesAsync ();

            return true;

        }

        public async Task<Book> GetBookById (int? id) {
            var book = await _bookDbContext.Books.FirstOrDefaultAsync(book => book.Id == id);
          

            return book;
        }

    
    }

}