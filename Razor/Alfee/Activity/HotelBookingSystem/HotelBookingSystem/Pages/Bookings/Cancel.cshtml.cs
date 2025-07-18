using HotelBookingSystem.Interface;
using HotelBookingSystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelBookingSystem.Pages.Bookings
{
    public class CancelModel : PageModel
    {
        private readonly IBookingService _bookingService;

        public CancelModel(IBookingService bookingService)
        {
            _bookingService = bookingService;
        }

        [BindProperty]
        public Booking Booking { get; set; }

        public async Task<IActionResult> OnGetAsync(int bookingId)
        {
            Booking = await _bookingService.GetBookingByIdAsync(bookingId);
            if (Booking == null)
            {
                return RedirectToPage("/Index");
            }

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (Booking == null)
            {
                return RedirectToPage("/Index");
            }

            await _bookingService.CancelBookingAsync(Booking.Id);
            return RedirectToPage("/Index");
        }
    }
}
