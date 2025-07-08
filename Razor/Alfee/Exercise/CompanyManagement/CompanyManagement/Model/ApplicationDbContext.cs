using Microsoft.EntityFrameworkCore;

namespace CompanyManagement.Model
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<CompanyMember> CompanyMembers { get; set; }

    }
}
