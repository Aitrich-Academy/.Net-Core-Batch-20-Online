using Bus_Ticket_Booking_System.Model;
using Microsoft.EntityFrameworkCore;


public class Program
{
      static void Main(string[] args)
    {
        using (var db = new BusContext())
        {
            db.Database.EnsureCreated();
            

            
            if (!db.Buses.Any())
            {
                db.Buses.AddRange(
                    new Bus {  BusName = "Bus 1", Route = "Tcr - Tvm", TotalSeats = 45, AvailableSeats = 40 },
                    new Bus {  BusName = "Bus 2", Route = "Kochi - Calicut", TotalSeats = 30, AvailableSeats = 30 },
                    new Bus {  BusName = "Bus 3", Route = "Tvm - Kasargod", TotalSeats = 25, AvailableSeats = 25}
                );

                db.SaveChanges();

                Console.WriteLine("Buses seeded.");
            }
        }

        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("==== Bus Ticket Booking ====");
            Console.WriteLine("1. View All Buses.");
            Console.WriteLine("2. Book Ticket.");
            Console.WriteLine("3. View All Bookings.");
            Console.WriteLine("4. Exit.");

            Console.Write("Enter your choice: ");
            var choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    ViewAllBuses();
                    break;

                case "2":
                    BookTicket();
                    break;

                case "3":
                    ViewAllBookings();
                    break;

                case "4":
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid choice!");
                    break;
            }
        }
    }

    static void ViewAllBuses()
    {
        using (var db = new BusContext())
        {
            var buses = db.Buses.ToList();

            Console.WriteLine("BusId | BusName | Route | AvailableSeats");

            foreach (var b in buses)
            {
                Console.WriteLine($"{b.BusId} | {b.BusName} | {b.Route} | {b.AvailableSeats}");

            }
        }
    }

    static void BookTicket()
    {
        using (var db = new BusContext())
        {
            Console.Write("Enter BusId: ");
            int busId = int.Parse(Console.ReadLine());

            var bus = db.Buses.Find(busId);
            if (bus == null)
            {
                Console.WriteLine("Bus not found.");
                return;
            }

            Console.Write("Enter Passenger Name: ");
            var name = Console.ReadLine();

            Console.Write("Enter Number of Tickets: ");
            int seats = int.Parse(Console.ReadLine());

            if (seats <= bus.AvailableSeats)
            {
                var booking = new Booking
                {
                    PassengerName = name,
                    SeatsBooked = seats,
                    BusId = busId
                };
                db.Bookings.Add(booking);
                bus.AvailableSeats -= seats;

                db.SaveChanges();

                Console.WriteLine("Booking successfully made.");
            }
            else
            {
                Console.WriteLine("Not enough seats.");
            }
        }
    }

    static void ViewAllBookings()
    {
        using (var db = new BusContext())
        {
            var bookingList = db.Bookings.Include(b => b.Bus).ToList();

            Console.WriteLine("BookingId | Passenger | Bus | seats");

            foreach (var booking in bookingList)
            {
                Console.WriteLine($"{booking.BookingId} | {booking.PassengerName} | {booking.Bus.BusName} | {booking.SeatsBooked}");

            }
        }
    }
}
    
