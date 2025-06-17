using Microsoft.EntityFrameworkCore.Internal;
using TICKET_Booking.Models;




public class Program
    {
     public static void Main(string[] args)
        {


        var context = new BookingDbContext();


        while (true)
        {
            Console.WriteLine("\n==== Bus Ticket Booking ====");
            Console.WriteLine("1.View All Buses");
            Console.WriteLine("2.Book Ticket");
            Console.WriteLine("3.view All Booking");
            Console.WriteLine("4.Exit");

          

            Console.Write("Enter choice: ");
            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1: ViewAllBuses(); break;
                case 2: SeatBooking(); break;
               
                case 3: ViewAllBooking(); break;
                case 4: return;
                default: Console.WriteLine("Invalid choice."); break;
            }
        }
    }



  
        static void SeatBooking()
        {
            var context = new BookingDbContext();
            {
                Console.WriteLine("___Ticket Booking______\n");

                Console.Write("Enter Bus ID for Booking: ");
                int busId = int.Parse(Console.ReadLine());

                Console.Write("Enter Passenger Name: ");
                string name = Console.ReadLine();

                Console.Write("Enter Number of Tickets: ");
                int numberOfTickets = int.Parse(Console.ReadLine());

                // Check if the bus exists
                var bus = context.bus.FirstOrDefault(b => b.BusId == busId);

                if (bus == null)
                {
                    Console.WriteLine("Bus not found!");
                    return;
                }

                // Check seat availability
                if (bus.AvailableSeats < numberOfTickets)
                {
                    Console.WriteLine($"Not enough seats available! Only {bus.AvailableSeats} left.");
                    return;
                }

                // Proceed with booking
                var booking = new Booking
                {
                    BusId = busId,
                    PassengerName = name,
                    SeatsBooked = numberOfTickets
                };

                context.bookings.Add(booking);

                // Update available seats in the bus
                bus.AvailableSeats -= numberOfTickets;

                context.SaveChanges();

                Console.WriteLine("Seats are Booked Successfully!");
            }
        }

    


    static void ViewAllBuses()
    {
        var Context=new BookingDbContext();
        {
            var bus = Context.bus.ToList();
            Console.WriteLine("\nAll Bus Details");
            foreach (var b in bus)
            {
                Console.WriteLine($"ID: {b.BusId} \nBusName: {b.BusName} \nBus Route:{b.Route} \nTotal Seat: {b.TotalSeats} \nAvilable Seats:{b.AvailableSeats}");
            }
        }
    }

   
        
    
             

    static void ViewAllBooking()
    {
        var context = new BookingDbContext();
        {
            var Booking = context.bookings.ToList();
            Console.WriteLine("\nView All Booking");
            foreach (var booking in Booking)
            {
                Console.WriteLine($"Bookid: {booking.BookingId}, bus Id: {booking.BusId},PassengerName:  {booking.PassengerName}, Seats Booked: {booking.SeatsBooked}");
            }
        }
    }
}