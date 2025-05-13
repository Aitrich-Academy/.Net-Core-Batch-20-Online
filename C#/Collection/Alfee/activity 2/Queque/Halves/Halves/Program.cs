using System;
using System.Collections.Generic;

class Program
{
    static void InterleaveQueue(Queue<int> queue)
    {
        int n = queue.Count / 2;

        // Temporary queue to hold the first half
        Queue<int> firstHalf = new Queue<int>();

        // Enqueue the first half of the queue
        for (int i = 0; i < n; i++)
        {
            firstHalf.Enqueue(queue.Dequeue());
        }

        // Interleave the two halves
        while (firstHalf.Count > 0)
        {
            Console.Write(firstHalf.Dequeue() + " ");
            Console.Write(queue.Dequeue() + " ");
        }
    }

    static void Main()
    {
        // Initial queue with an even number of elements
        Queue<int> queue = new Queue<int>();
        queue.Enqueue(1);
        queue.Enqueue(2);
        queue.Enqueue(3);
        queue.Enqueue(4);

        Console.WriteLine("Interleaved Queue:");
        InterleaveQueue(queue);
    }
}