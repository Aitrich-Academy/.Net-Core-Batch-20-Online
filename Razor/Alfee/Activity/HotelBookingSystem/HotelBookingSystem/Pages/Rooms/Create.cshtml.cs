using HotelBookingSystem.Dto;
using HotelBookingSystem.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelBookingSystem.Pages.Rooms
{
    public class CreateModel : PageModel
    {
        private readonly IRoomService _roomService;

        public CreateModel(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [BindProperty]
        public RoomDto Room { get; set; }

        public void OnGet()
        {
            Room = new RoomDto();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            await _roomService.AddRoomAsync(Room);
            return RedirectToPage("List");
        }
    }
}
