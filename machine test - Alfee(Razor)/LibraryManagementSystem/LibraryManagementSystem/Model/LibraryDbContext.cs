using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Model
{
    public class LibraryDbContext: DbContext
    {
        public LibraryDbContext(DbContextOptions<LibraryDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
    }
}
