using Microsoft.EntityFrameworkCore;

namespace JOBMANAGEMENT.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Job> Jobs { get; set; }

    }
}
