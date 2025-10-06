using Microsoft.EntityFrameworkCore;

namespace Login___JWT.Model
{
    public class UserDbContext:DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
