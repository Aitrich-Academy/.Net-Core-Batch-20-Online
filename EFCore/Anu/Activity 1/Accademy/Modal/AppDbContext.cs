using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Accademy.Modal
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder options)

        {
            
            options.UseSqlServer("Data Source=ANOOD;Initial Catalog=Accademy;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mark>().HasKey(m => m.Mark_Id);
            modelBuilder.Entity<Student>().HasKey(m => m.Student_Id);
        }

        public DbSet<Student> students  { get; set; }
        public DbSet<Mark> marks { get; set; }
    }
}
