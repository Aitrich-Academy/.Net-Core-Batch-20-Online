using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
