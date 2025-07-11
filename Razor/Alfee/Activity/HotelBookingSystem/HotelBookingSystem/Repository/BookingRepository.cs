using HotelBookingSystem.Interface;
using HotelBookingSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace HotelBookingSystem.Repository
{
    public class BookingRepository : IBookingRepository
    {
        private readonly HotelDbContext _context;

        public BookingRepository(HotelDbContext context)
        {
            _context = context;
        }

        public async Task<List<Booking>> GetAllBookingsAsync()
        {
            return await _context.Bookings
                                 .Include(b => b.Room)
                                 .ToListAsync();
        }

        public async Task<Booking> GetBookingByIdAsync(int id)
        {
            return await _context.Bookings
                                 .Include(b => b.Room)
                                 .FirstOrDefaultAsync(b => b.Id == id);
        }

        public async Task AddBookingAsync(Booking booking)
        {
            var room = await _context.Rooms.FindAsync(booking.RoomId);
            if (room != null && room.IsAvailable)
            {
                booking.Status = "Booked";
                room.IsAvailable = false;

                _context.Bookings.Add(booking);
                await _context.SaveChangesAsync();
            }
        }

        public async Task CancelBookingAsync(int bookingId)
        {
            var booking = await _context.Bookings.FindAsync(bookingId);
            if (booking != null && booking.Status != "Cancelled")
            {
                booking.Status = "Cancelled";

                var room = await _context.Rooms.FindAsync(booking.RoomId);
                if (room != null)
                {
                    room.IsAvailable = true;
                }

                await _context.SaveChangesAsync();
            }
        }
    }
}
