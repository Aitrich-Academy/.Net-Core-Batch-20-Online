using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue_based_Ticket_Counter_Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();

            Console.Write("How many people are in the queue? ");
            int numberOfPeople = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfPeople; i++)
            {
                Console.Write($"Enter name of person {i}: ");
                string name = Console.ReadLine();
                queue.Enqueue(name);
            }

            Console.WriteLine("\nServing people...\n");

            int time = 0;
            while (queue.Count > 0)
            {
                string person = queue.Dequeue();
                time++;
                Console.WriteLine($"Minute {time}: Serving {person}");
            }

            Console.WriteLine($"\nTotal time taken: {time} minute(s).");
        }
    }
    }

