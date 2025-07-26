using HotelBookingSystem.Dto;
using HotelBookingSystem.Model;

namespace HotelBookingSystem.Interface
{
    public interface IBookingService
    {
        Task<List<Booking>> GetAllBookingsAsync();
        Task<Booking> GetBookingByIdAsync(int id);
        Task<Booking> CreateBookingAsync(BookingDto bookingDto);
        Task CancelBookingAsync(int id);
    }
}
