using Microsoft.EntityFrameworkCore;

namespace StudentManagement.Model
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options) : base(options)
        { }
        public DbSet<student> students { get; set; }
    }
}
