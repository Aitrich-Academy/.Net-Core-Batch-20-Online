using SampleAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace SampleAPI.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

       public DbSet<Product> Products { get; set; } 
    }
}
