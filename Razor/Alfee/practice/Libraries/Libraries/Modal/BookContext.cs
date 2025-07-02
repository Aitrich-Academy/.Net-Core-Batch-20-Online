using Microsoft.EntityFrameworkCore;

namespace Libraries.Modal
{
    public class BookContext: DbContext
    {
        public DbSet<Book> Book { get; set; }

        public BookContext(DbContextOptions<BookContext> options) : base(options) { }

    }
}
