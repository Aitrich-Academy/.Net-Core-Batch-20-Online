internal class Program
{
    //    3. Pyramid Pattern
    //  *
    // * *
    //* * *
    //* * * *
    //* * * * *
    private static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of rows:");
        int rows = Convert.ToInt32(Console.ReadLine());

        int stars = 1; // Start with one star

        for (int i = 1; i <= rows; i++)
        {
            // Print spaces
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }

            // Print stars
            for (int k = 1; k <= stars; k++)
            {
                Console.Write("*");
            }

            stars++; // Increase the number of stars for the next row
            Console.WriteLine(); // Move to the next line
        }
    }
}