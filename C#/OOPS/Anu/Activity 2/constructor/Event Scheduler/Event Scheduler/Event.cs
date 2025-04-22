using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Scheduler
{
    internal class Event
    {
        public string EventName;
        public DateTime Date;
        public string Location;

        public Event(string eventName, DateTime date, string location)
        {
            EventName = eventName;
            Date = date;
            Location = location;
        }

        public void DisplayEvent()
        {
            Console.WriteLine("Event Name: " + EventName);
            Console.WriteLine("Date: " + Date.ToString("MMMM dd, yyyy"));
            Console.WriteLine("Location: " + Location);
            Console.WriteLine("--------------------------");
        }
    }
}
