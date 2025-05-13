using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a queue
        Queue<int> queue = new Queue<int>();

        // Enqueue 5 elements
        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);
        queue.Enqueue(40);
        queue.Enqueue(50);

        // Dequeue 2 elements
        if (queue.Count >= 2)
        {
            queue.Dequeue();
            queue.Dequeue();
        }

        // Display remaining elements
        Console.WriteLine("Remaining elements in the queue:");
        foreach (int item in queue)
        {
            Console.WriteLine(item);
        }
    }
}