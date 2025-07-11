using System.ComponentModel.DataAnnotations;

namespace HotelBookingSystem.Dto
{
    public class BookingDto
    {
        public int RoomId { get; set; }      
        public string CustomerName { get; set; }       
        public DateTime CheckInDate { get; set; }        
        public DateTime CheckOutDate { get; set; }
    }
}
