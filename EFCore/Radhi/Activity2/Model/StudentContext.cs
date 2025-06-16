using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Activity2.Model
{
    public class StudentContext : DbContext
    {

        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=DESKTOP-3OCUFDV;Initial Catalog=activity2;Integrated Security=True;Trust Server Certificate=True");
        }
    }
       
}
