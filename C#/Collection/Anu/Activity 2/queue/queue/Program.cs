using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a queue of integers
            Queue<int> queue = new Queue<int>();

            // Enqueue 5 elements
            Console.WriteLine("Enqueuing 5 elements:");
            for (int i = 1; i <= 5; i++)
            {
                queue.Enqueue(i);
                Console.WriteLine($"Enqueued: {i}");
            }

            // Dequeue 2 elements
            Console.WriteLine("\nDequeuing 2 elements:");
            for (int i = 0; i < 2; i++)
            {
                if (queue.Count > 0)
                {
                    int removed = queue.Dequeue();
                    Console.WriteLine($"Dequeued: {removed}");
                }
                else
                {
                    Console.WriteLine("Queue is empty!");
                }
            }

            // Display remaining elements
            Console.WriteLine("\nRemaining elements in the queue:");
            foreach (int item in queue)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
    }

