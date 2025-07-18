using HotelBookingSystem.Interface;
using HotelBookingSystem.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HotelBookingSystem.Pages.Rooms
{
    public class ListModel : PageModel
    {
        private readonly IRoomService _roomService;

        public List<Room> Rooms { get; set; }

        public ListModel(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public async Task OnGetAsync()
        {
            Rooms = await _roomService.GetAllRoomsAsync();
        }
    }

}
