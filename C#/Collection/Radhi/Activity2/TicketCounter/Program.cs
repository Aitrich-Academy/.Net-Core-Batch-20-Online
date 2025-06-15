internal class Program
{
    class TicketCounter
    {
        public static void SimulateTicketCounter(Queue<string> peopleQueue)
        {
            int time = 0;

            Console.WriteLine("Ticket Counter Simulation:\n");

            while (peopleQueue.Count > 0)
            {
                string person = peopleQueue.Dequeue();
                time += 1; // Each person takes 1 minute
                Console.WriteLine($"{person} is served at minute {time}");
            }

            Console.WriteLine($"\nTotal time taken: {time} minutes");
        }

        static void Main()
        {
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("Alice");
            queue.Enqueue("Bob");
            queue.Enqueue("Charlie");
            queue.Enqueue("Diana");

            SimulateTicketCounter(queue);
        }
    }
}