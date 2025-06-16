using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace activity1.Model
{
    public class LibraryContext:DbContext
    {
        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Author { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)

        {
            options.UseSqlServer("Data Source=DESKTOP-3OCUFDV;Initial Catalog=Library;Integrated Security=True;Trust Server Certificate=True");
        }

    }
}
