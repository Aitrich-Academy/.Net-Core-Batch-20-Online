using Microsoft.EntityFrameworkCore;

namespace HotelBookingSystem.Model
{
    public class HotelDbContext:DbContext
    {
        public HotelDbContext(DbContextOptions<HotelDbContext> options) : base(options) { }

        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
    }
}
