using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TICKET_Booking.Models
{
    public class Bus
    {

         public int BusId { get; set; }
        public string BusName { get; set; }
        public  int TotalSeats { get; set; }
        public int AvailableSeats {  get; set; }
        public string Route {  get; set; }
        public ICollection<Booking> Bookings { get; set; }




    }
}
