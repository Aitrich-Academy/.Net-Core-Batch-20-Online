using Microsoft.EntityFrameworkCore;

namespace StudentPortal.Models
{
    public class StudentDbContext:DbContext
    {
        public StudentDbContext(DbContextOptions<StudentDbContext> options) : base(options) { }
        
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Data Source=AFRA;Initial Catalog=DB_MVC;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
    }
}
