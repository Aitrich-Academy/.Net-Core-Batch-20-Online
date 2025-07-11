using HotelBookingSystem.Model;

namespace HotelBookingSystem.Interface
{
    public interface IBookingRepository
    {
        Task<List<Booking>> GetAllBookingsAsync();
        Task<Booking> GetBookingByIdAsync(int id);
        Task AddBookingAsync(Booking booking);
        Task CancelBookingAsync(int bookingId);
    }
}
