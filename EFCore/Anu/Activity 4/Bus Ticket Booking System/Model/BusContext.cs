using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Bus_Ticket_Booking_System.Model
{
    public class BusContext :DbContext 
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             
            optionsBuilder.UseSqlServer("Data Source=ANOOD;Initial Catalog=Bus_Ticket_Booking_System;Integrated Security=True;Trust Server Certificate=True");
        }

        public DbSet<Bus> Buses { get; set; }
        public DbSet<Booking> Bookings { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bus>().HasKey(m => m.BusId);
            modelBuilder.Entity<Booking>().HasKey(m => m.BookingId);
        }
    }
}
