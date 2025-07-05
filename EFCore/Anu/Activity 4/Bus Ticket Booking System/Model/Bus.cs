using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking_System.Model
{
    public class Bus
    {
        public int BusId { get; set; }
        public string BusName { get; set; }
        public string Route { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }

        public List<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
