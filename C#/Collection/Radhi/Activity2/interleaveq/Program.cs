internal class Program
{
    static void InterleaveQueue(Queue<int> queue)
    {
        if (queue.Count % 2 != 0)
        {
            Console.WriteLine("Queue must have an even number of elements.");
            return;
        }

        int halfSize = queue.Count / 2;
        Queue<int> firstHalf = new Queue<int>();

        // Step 1: Enqueue first half into a temp queue
        for (int i = 0; i < halfSize; i++)
        {
            firstHalf.Enqueue(queue.Dequeue());
        }

        // Step 2: Interleave elements
        while (firstHalf.Count > 0)
        {
            queue.Enqueue(firstHalf.Dequeue()); // from first half
            queue.Enqueue(queue.Dequeue());     // from second half
        }
    }

    static void Main()
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);
        q.Enqueue(4);

        Console.WriteLine("Original Queue: " + string.Join(" ", q));
        InterleaveQueue(q);
        Console.WriteLine("Interleaved Queue: " + string.Join(" ", q));
    }
}