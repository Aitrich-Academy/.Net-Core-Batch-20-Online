using HotelBookingSystem.Dto;
using HotelBookingSystem.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelBookingSystem.Pages.Rooms
{
    public class EditModel : PageModel
    {
        private readonly IRoomService _roomService;

        public EditModel(IRoomService roomService)
        {
            _roomService = roomService;
        }

        [BindProperty]
        public RoomDto Room { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var existingRoom = await _roomService.GetRoomByIdAsync(id);
            if (existingRoom == null) return RedirectToPage("List");

            Room = new RoomDto
            {
                Id = existingRoom.Id,
                RoomNumber = existingRoom.RoomNumber,
                RoomType = existingRoom.RoomType,
                Price = existingRoom.Price,
                IsAvailable = existingRoom.IsAvailable
            };

            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();

            await _roomService.UpdateRoomAsync(Room);
            return RedirectToPage("List");
        }
    }

}
