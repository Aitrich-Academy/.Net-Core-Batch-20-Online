using Microsoft.EntityFrameworkCore;
using AdminPortal.Models;

namespace AdminPortal.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee>  employees { get; set; }
    }
}
