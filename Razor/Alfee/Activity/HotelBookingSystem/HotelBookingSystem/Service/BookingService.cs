using HotelBookingSystem.Dto;
using HotelBookingSystem.Interface;
using HotelBookingSystem.Model;
using HotelBookingSystem.Repository;

namespace HotelBookingSystem.Service
{
    public class BookingService:IBookingService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly IRoomRepository _roomRepository;
        public BookingService(IBookingRepository bookingRepository, IRoomRepository roomRepository)
        {
            _bookingRepository = bookingRepository;
            _roomRepository = roomRepository;
        }

        public async Task<List<Booking>> GetAllBookingsAsync()
        {
            return await _bookingRepository.GetAllBookingsAsync();
        }

        public async Task<Booking> GetBookingByIdAsync(int id)
        {
            return await _bookingRepository.GetBookingByIdAsync(id);
        }

        public async Task<Booking> CreateBookingAsync(BookingDto bookingDto)
        {
            var booking = new Booking
            {
                RoomId = bookingDto.RoomId,
                CustomerName = bookingDto.CustomerName,
                CheckInDate = bookingDto.CheckInDate,
                CheckOutDate = bookingDto.CheckOutDate,
                Status = "Booked"
            };

            await _bookingRepository.AddBookingAsync(booking);
            return booking;
        }

        public async Task CancelBookingAsync(int id)
        {
            await _bookingRepository.CancelBookingAsync(id);
        }
    }
}
