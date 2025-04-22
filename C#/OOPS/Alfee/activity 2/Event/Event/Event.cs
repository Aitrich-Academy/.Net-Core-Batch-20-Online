using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_oops
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

        public void DisplayEvent()
        {
            Console.WriteLine("Event:" + EventName);
            Console.WriteLine("Date:" + Date);
            Console.WriteLine("Location:" + Location);
            Console.WriteLine();
        }
    }
}
