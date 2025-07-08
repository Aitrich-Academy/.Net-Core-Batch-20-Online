using Microsoft.EntityFrameworkCore;

namespace SimpleAuthentication.Models
{
    public class ApplicationDbContext :DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
