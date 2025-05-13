using System;
using System.Collections.Generic;

class Program
{
    // Function to reverse a queue
    static Queue<int> ReverseQueue(Queue<int> originalQueue)
    {
        Stack<int> stack = new Stack<int>();

        // Move all elements from queue to stack
        while (originalQueue.Count > 0)
        {
            stack.Push(originalQueue.Dequeue());
        }

        // Create a new queue and enqueue elements from the stack
        Queue<int> reversedQueue = new Queue<int>();
        while (stack.Count > 0)
        {
            reversedQueue.Enqueue(stack.Pop());
        }

        return reversedQueue;
    }

    static void Main()
    {
        Queue<int> myQueue = new Queue<int>();
        myQueue.Enqueue(1);
        myQueue.Enqueue(2);
        myQueue.Enqueue(3);
        myQueue.Enqueue(4);
        myQueue.Enqueue(5);

        Console.WriteLine("Original Queue:");
        foreach (int item in myQueue)
            Console.Write(item + " ");
        Console.WriteLine();

        Queue<int> reversed = ReverseQueue(new Queue<int>(myQueue));

        Console.WriteLine("Reversed Queue:");
        foreach (int item in reversed)
            Console.Write(item + " ");
    }
}