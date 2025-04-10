internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number of terms: ");
        int n = int.Parse(Console.ReadLine());

        int first = 0, second = 1, next;

        Console.Write("Fibonacci Series: " + first + " " + second + " ");

        for (int i = 2; i < n; i++)
        {
            next = first + second;
            Console.Write(next + " ");
            first = second;
            second = next;
        }

        Console.WriteLine();
    }
}