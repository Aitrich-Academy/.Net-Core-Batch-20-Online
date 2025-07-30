using Microsoft.EntityFrameworkCore;

namespace JobProviders.Model
{
    public class JobProviderDbContext:DbContext
    {
        public JobProviderDbContext(DbContextOptions<JobProviderDbContext> options) : base(options) { }

        public DbSet<JobProvider> JobProviders { get; set; }

        public DbSet<Job> Jobs { get; set; }
    }
}
