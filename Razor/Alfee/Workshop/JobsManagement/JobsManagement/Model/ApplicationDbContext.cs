using Microsoft.EntityFrameworkCore;

namespace JobsManagement.Model
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Jobs> Jobs { get; set; }
    }
}
