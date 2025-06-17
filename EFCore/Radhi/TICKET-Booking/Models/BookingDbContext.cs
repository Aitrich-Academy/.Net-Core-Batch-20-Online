using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace TICKET_Booking.Models
{
    public class BookingDbContext:DbContext
    {
     public DbSet<Booking> bookings {  get; set; }
       public  DbSet<Bus> bus{  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=DESKTOP-3OCUFDV;Initial Catalog=Ticket;Integrated Security=True;Trust Server Certificate=True");
        }

    }
}
