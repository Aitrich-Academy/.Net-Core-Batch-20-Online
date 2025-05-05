using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverse_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Example queue
            Queue<int> originalQueue = new Queue<int>();
            originalQueue.Enqueue(1);
            originalQueue.Enqueue(2);
            originalQueue.Enqueue(3);
            originalQueue.Enqueue(4);

            Console.WriteLine("Original Queue:");
            PrintQueue(originalQueue);

            Queue<int> reversedQueue = ReverseQueue(originalQueue);

            Console.WriteLine("\nReversed Queue:");
            PrintQueue(reversedQueue);

            Console.ReadLine(); // Pause
        }

        // Function to reverse a queue
        static Queue<int> ReverseQueue(Queue<int> inputQueue)
        {
            Stack<int> stack = new Stack<int>();

            // Dequeue all elements into the stack
            while (inputQueue.Count > 0)
            {
                stack.Push(inputQueue.Dequeue());
            }

            // Enqueue them back into a new queue (reversed order)
            Queue<int> reversedQueue = new Queue<int>();
            while (stack.Count > 0)
            {
                reversedQueue.Enqueue(stack.Pop());
            }

            return reversedQueue;
        }

        // Helper method to print queue contents
        static void PrintQueue(Queue<int> queue)
        {
            foreach (int item in queue)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
    }

