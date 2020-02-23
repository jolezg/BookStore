using Microsoft.EntityFrameworkCore;
using BookStoreApi.Domain.Models;
// Add the ContosoPets.Domain.Models using statement

namespace BookStore.DataAccess.Data {
    public partial class BookStoreContext : DbContext {
        public BookStoreContext (DbContextOptions<BookStoreContext> options) : base (options) { }

        // Add the DbSet<T> properties >
        public DbSet<User> Users { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<BookLoan> BookLoans { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}