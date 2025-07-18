using Microsoft.EntityFrameworkCore;

namespace UserManagement.Models
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }  
        public DbSet<Job> Jobs { get; set; }
        public DbSet<AppliedJob> AppliedJobs { get; set; }
    }
}
