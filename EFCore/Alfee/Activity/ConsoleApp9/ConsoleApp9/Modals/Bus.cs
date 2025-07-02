using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9.Modals
{
    public class Bus
    {
        public int BusId { get; set; }
        public string BusName { get; set; }
        public string Route { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public ICollection<Booking> Bookings { get; set; } = new List<Booking>();
    }
}
