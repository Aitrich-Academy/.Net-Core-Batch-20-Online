using Microsoft.EntityFrameworkCore;

namespace HospitalManagement.Model
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Doctors> doctors { get; set; }
    }
}
