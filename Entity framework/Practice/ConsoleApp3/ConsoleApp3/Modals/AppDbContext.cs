using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp3.Modals
{
    public class AppDbContext:DbContext
    {
        public DbSet<Students> Students { get; set; }
        public DbSet<Marks> Markers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=LAPTOP-DBMHTCV2;Initial Catalog=Academy;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
