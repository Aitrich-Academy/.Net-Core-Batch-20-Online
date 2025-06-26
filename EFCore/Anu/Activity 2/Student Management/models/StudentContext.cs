using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Student_Management.models
{
    public class StudentContext : DbContext
    {
        public DbSet<Student> Students { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Replace with your actual connection string
            optionsBuilder.UseSqlServer("Data Source=ANOOD;Initial Catalog=StudentManagement;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
