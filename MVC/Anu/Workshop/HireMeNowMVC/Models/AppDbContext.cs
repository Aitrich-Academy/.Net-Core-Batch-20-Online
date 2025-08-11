using Microsoft.EntityFrameworkCore;

namespace HireMeNowMVC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<Job> Jobs { get; set; }
        public virtual DbSet<User> Users { get; set; }
    }
}
