internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = n; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}
    
