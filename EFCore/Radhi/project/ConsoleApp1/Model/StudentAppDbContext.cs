using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp1.Model
{
   public class StudentAppDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Mark> Marks { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=DESKTOP-3OCUFDV;Initial Catalog=Project1;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
