using System.ComponentModel.DataAnnotations;

namespace HotelBookingSystem.Dto
{
    public class RoomDto
    {
        public int Id { get; set; }
        public string RoomNumber { get; set; }  
        public string RoomType { get; set; }       
        public decimal Price { get; set; }
        public bool IsAvailable { get; set; }
    }
}
