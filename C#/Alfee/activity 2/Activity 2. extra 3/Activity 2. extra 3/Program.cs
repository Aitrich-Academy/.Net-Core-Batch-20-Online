internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number of rows: ");
        int num = Convert.ToInt32(Console.ReadLine());

        for (int i = num; i >= 1; i--)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }
}