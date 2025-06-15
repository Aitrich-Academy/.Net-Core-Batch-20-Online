using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp2.Modal
{
    public class AppDbContent: DbContext
    {
        public DbSet<Product> Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Server=LAPTOP-DBMHTCV2;Initial Catalog=ProductList;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        }
        
    }
}
