using Microsoft.EntityFrameworkCore;

namespace BOOKAPI.Models
{
    public class BookDbContext:DbContext
    {
        public BookDbContext(DbContextOptions<BookDbContext>options):base(options) { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Product> Products { get; set; }
       
        
    }
}
