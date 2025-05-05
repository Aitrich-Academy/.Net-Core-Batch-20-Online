using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interleave_Two_Halves_of_a_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();

            Console.WriteLine("Enter even number of integers separated by spaces:");
            string[] input = Console.ReadLine().Split(' ');
            foreach (var item in input)
            {
                queue.Enqueue(int.Parse(item));
            }

            if (queue.Count % 2 != 0)
            {
                Console.WriteLine("The queue must contain an even number of elements.");
                return;
            }

            InterleaveQueue(queue);

            Console.WriteLine("Interleaved queue:");
            foreach (int num in queue)
            {
                Console.Write(num + " ");
            }
        }

        static void InterleaveQueue(Queue<int> queue)
        {
            int halfSize = queue.Count / 2;
            Queue<int> firstHalf = new Queue<int>();

            // Move first half into a new queue
            for (int i = 0; i < halfSize; i++)
            {
                firstHalf.Enqueue(queue.Dequeue());
            }

            // Interleave both halves back into the original queue
            while (firstHalf.Count > 0)
            {
                queue.Enqueue(firstHalf.Dequeue());
                queue.Enqueue(queue.Dequeue());
            }
        }
    }
}
