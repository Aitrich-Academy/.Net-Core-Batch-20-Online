using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_Scheduler
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Event event1 = new Event("Music Festival", new DateTime(2025, 5, 10), "New York City");
            Event event2 = new Event("Tech Conference", new DateTime(2025, 6, 21), "San Francisco");
            Event event3 = new Event("Art Exhibition", new DateTime(2025, 7, 15), "Chicago");

             
            event1.DisplayEvent();
            event2.DisplayEvent();
            event3.DisplayEvent();

             
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
