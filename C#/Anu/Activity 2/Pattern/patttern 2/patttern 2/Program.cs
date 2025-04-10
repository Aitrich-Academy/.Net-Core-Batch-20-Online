internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            // Print spaces
            for (int j = 1; j <= n - i; j++)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int k = 1; k <= (2 * i - 1); k++)
            {
                Console.Write("*");
            }

            // Move to next line
            Console.WriteLine();
        }
    }
}
    
