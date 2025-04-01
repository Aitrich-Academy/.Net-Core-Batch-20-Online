internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());

        // Number Pyramid
        for (int i = 1; i <= rows; i++)
        {
            // Print spaces
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

            // Print numbers
            for (int k = 1; k <= i; k++)
            {
                Console.Write(k + " ");
            }

            Console.WriteLine();
        }
    }
}