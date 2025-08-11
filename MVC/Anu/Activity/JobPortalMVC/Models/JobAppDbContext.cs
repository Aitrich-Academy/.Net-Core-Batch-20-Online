using Microsoft.EntityFrameworkCore;

namespace JobPortalMVC.Models
{
    public class JobAppDbContext : DbContext
    {
        public JobAppDbContext(DbContextOptions<JobAppDbContext> options)
           : base(options)
        {
        }

        public DbSet<Job> Jobs { get; set; }
    }
}
