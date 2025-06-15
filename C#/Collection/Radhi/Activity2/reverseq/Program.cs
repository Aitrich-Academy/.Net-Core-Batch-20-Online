using reverseq;

internal class Program
{
    private static void Main(string[] args)
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(1);
        q.Enqueue(2);
        q.Enqueue(3);

        QueueReverser.ReverseSimple(q);

        foreach (int item in q)
        {
            Console.Write(item + " "); // Output: 3 2 1
        }
    }
}