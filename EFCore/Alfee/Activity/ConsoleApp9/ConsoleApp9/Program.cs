using ConsoleApp9.Modals;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

internal class Program
{
    private static void Main(string[] args)
    {
        using (var db = new AppDbContext())
        {
            while (true)
            {
                Console.WriteLine("\n-----***-----Bus Ticket Booking-----***-----");
                Console.WriteLine("1. View All Buses");
                Console.WriteLine("2. Book Ticket");
                Console.WriteLine("3. View All Bookings");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":ViewBuses(db);
                        break;
                    case "2":
                        BookTicket(db);
                        break;
                    case "3":
                        ViewBookings(db);
                        break;
                    case "4":
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }

            }
        }
    }

    static void ViewBuses(AppDbContext db)
    {
        var buses = db.Buses.ToList();
        Console.WriteLine("\n----*---- Available Buses ----*----");
        foreach (var bus in buses)
        {
            Console.WriteLine($"BusId: {bus.BusId}, Name: {bus.BusName}, Route: {bus.Route}, Available Seats: {bus.AvailableSeats}");
        }
    }
}