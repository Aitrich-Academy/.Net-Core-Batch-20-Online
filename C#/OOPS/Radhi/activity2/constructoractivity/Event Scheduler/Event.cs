using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Scheduler
{
    internal class Event
    {
        
        public string EventName;
        public string Date;
        public string Location;

        public Event(string eventName, string date, string location)
        {
            EventName = eventName;
            Date = date;
            Location = location;
        }
        public void  Display()
        {
            
                Console.WriteLine($"Event Name:{EventName} \n Date:{Date} \n Location:{Location}");
            
        }
    }
}
