using Microsoft.EntityFrameworkCore;

namespace WorkshopJobProviderApp.Model
{
    public class JobproviderAppDbContext:DbContext
    {
        public JobproviderAppDbContext(DbContextOptions<JobproviderAppDbContext> options) : base(options) { }
        public DbSet<Job> Jobs {  get; set; }
        public DbSet<JobProvider>JobProviders { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Job>()
                .Property(e => e.Salary)
                .HasPrecision(18, 2);  // 👈 Fixes the warning
        }
    }
}
