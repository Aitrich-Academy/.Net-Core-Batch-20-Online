using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Simulate people standing in a queue
        Queue<string> ticketQueue = new Queue<string>();

        // Add people to the queue
        ticketQueue.Enqueue("Alice");
        ticketQueue.Enqueue("Bob");
        ticketQueue.Enqueue("Charlie");
        ticketQueue.Enqueue("David");
        ticketQueue.Enqueue("Eva");

        int time = 0;

        Console.WriteLine("Ticket Counter Simulation:\n");

        while (ticketQueue.Count > 0)
        {
            string person = ticketQueue.Dequeue();
            time += 1; // Each person takes 1 minute
            Console.WriteLine($"{person} is served at minute {time}");
        }

        Console.WriteLine($"\nTotal time taken: {time} minutes");
    }
}