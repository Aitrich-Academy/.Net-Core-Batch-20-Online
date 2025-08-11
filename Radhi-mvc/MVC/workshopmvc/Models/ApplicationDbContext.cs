using Microsoft.EntityFrameworkCore;

namespace workshopmvc.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Company> Company { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Job> Job { get; set; } 
    }
}
