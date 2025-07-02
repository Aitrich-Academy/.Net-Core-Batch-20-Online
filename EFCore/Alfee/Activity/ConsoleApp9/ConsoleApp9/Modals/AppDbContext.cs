using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ConsoleApp9.Modals
{
    public class AppDbContext:DbContext
    {
        public DbSet<Bus> Buses { get; set; }
        public DbSet<Booking> Bookings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=LAPTOP-DBMHTCV2;Initial Catalog=BusTicket;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
