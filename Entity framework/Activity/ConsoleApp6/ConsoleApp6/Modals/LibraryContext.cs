using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp6.Modals
{
    public class LibraryContext:DbContext
    {
        public DbSet<Author> authors { get; set; }
        public DbSet<Book> books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
           options.UseSqlServer("Data Source=LAPTOP-DBMHTCV2;Initial Catalog=Library;Integrated Security=True;Trust Server Certificate=True");
        }

    }
}
