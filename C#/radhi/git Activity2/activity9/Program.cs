internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());

        // Upper part of diamond
        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

        // Lower part of diamond
        for (int i = rows - 1; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

    }
}
 