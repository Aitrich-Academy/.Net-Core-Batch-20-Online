using HotelBookingSystem.Dto;
using HotelBookingSystem.Interface;
using HotelBookingSystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelBookingSystem.Pages.Bookings
{
    public class BookModel : PageModel
    {
        private readonly IRoomService _roomService;
        private readonly IBookingService _bookingService;
        public BookModel(IRoomService roomService, IBookingService bookingService)
        {
            _roomService = roomService;
            _bookingService = bookingService;
        }

        [BindProperty]
        public BookingDto Booking { get; set; }

        public Room Room { get; set; }

        public async Task<IActionResult> OnGetAsync(int roomId)
        {
            Room = await _roomService.GetRoomByIdAsync(roomId);
            if (Room == null || !Room.IsAvailable)
            {
                return RedirectToPage("/Index");
            }

            Booking = new BookingDto { RoomId = roomId };
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                Room = await _roomService.GetRoomByIdAsync(Booking.RoomId);
                return Page();
            }

            await _bookingService.CreateBookingAsync(Booking);
            return RedirectToPage("/Bookings/Confirmation");
        }
    }
}
