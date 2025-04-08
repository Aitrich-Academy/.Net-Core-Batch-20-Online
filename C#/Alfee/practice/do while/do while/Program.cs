internal class Program
{
    private static void Main(string[] args)
    {
        int number;

        do
        {
            Console.WriteLine("enter a number");
            number = Convert.ToInt32(Console.ReadLine());

            if (number >= 0)
            {
                Console.WriteLine("You entered: " + number);
            }

        
        } while (number >= 0); // Stop when a negative number is entered

        Console.WriteLine("Negative number detected. Program stopped.");
    }
}