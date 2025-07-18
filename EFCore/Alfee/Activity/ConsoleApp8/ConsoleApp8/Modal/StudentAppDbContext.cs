using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure.Internal;

namespace ConsoleApp8.Modal
{
    internal class StudentAppDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Mark> Marks { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=LAPTOP-DBMHTCV2;Initial Catalog=School;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
