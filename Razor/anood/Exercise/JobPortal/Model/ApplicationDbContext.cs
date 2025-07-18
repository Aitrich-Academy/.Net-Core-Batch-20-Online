using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;

namespace JobPortal.Model
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Jobs> Jobs { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Applied> AppliedJobs { get; set; }
    }
}
