using Microsoft.EntityFrameworkCore;

namespace College.Modal
{
    public class StudentsContext: DbContext
    {
        public DbSet<Students> Students { get; set; }

        public StudentsContext(DbContextOptions<StudentsContext> options) : base(options) { }
    }
}
