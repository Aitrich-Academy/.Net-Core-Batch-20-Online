using Microsoft.EntityFrameworkCore;

namespace JWT_Login.Models
{
    public class UserDbContext : DbContext 
    {
        public UserDbContext(DbContextOptions options) : base(options) { }
        public DbSet<User> users { get; set; }
    }
}
