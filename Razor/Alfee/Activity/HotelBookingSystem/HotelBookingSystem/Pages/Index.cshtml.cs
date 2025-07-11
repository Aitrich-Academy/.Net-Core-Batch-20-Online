using HotelBookingSystem.Interface;
using HotelBookingSystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelBookingSystem.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IRoomService _roomService;

        public List<Room> AvailableRooms { get; set; }

        public IndexModel(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public async Task OnGetAsync()
        {
            AvailableRooms = await _roomService.GetAvailableRoomsAsync();
        }
    }
}
