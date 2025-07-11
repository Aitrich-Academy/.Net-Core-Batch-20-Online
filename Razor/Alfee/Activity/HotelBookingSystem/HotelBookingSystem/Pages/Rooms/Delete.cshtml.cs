using HotelBookingSystem.Interface;
using HotelBookingSystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelBookingSystem.Pages.Rooms
{
    public class DeleteModel : PageModel
    {
        private readonly IRoomService _roomService;

        public DeleteModel(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [BindProperty]
        public Room Room { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Room = await _roomService.GetRoomByIdAsync(id);
            if (Room == null) return RedirectToPage("List");
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            await _roomService.DeleteRoomAsync(Room.Id);
            return RedirectToPage("List");
        }
    }
}
