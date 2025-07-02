using Microsoft.EntityFrameworkCore;

namespace BookManagement.Model
{
    public class BookContext : DbContext
    {
      public BookContext(DbContextOptions<BookContext> options) : base(options)
        { }
        public DbSet<Book> books { get; set; }

    }
}
