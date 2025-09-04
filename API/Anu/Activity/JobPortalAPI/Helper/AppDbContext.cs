using Microsoft.EntityFrameworkCore;
using JobPortalAPI.Models;

namespace JobPortalAPI.Helper
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Job> Jobs { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
