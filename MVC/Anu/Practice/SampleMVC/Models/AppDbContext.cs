using SampleMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace SampleMVC.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students { get; set; }
    }
}
