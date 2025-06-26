using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bus_Ticket_Booking_System.Model
{
    public class Booking
    {
        public int BookingId { get; set; }
        public string PassengerName { get; set; }
        public int SeatsBooked { get; set; }

         
        public int BusId { get; set; }
        public Bus Bus { get; set; }
    }
}
