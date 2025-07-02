using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Modals
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
