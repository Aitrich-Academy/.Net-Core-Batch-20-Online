internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number == 0)
        {
            Console.WriteLine("Number of digits: 1");
            return;
        }

        number = Math.Abs(number); // Handle negative numbers
        int count = 0;

        for (; number > 0; number /= 10)
        {
            count++;
        }

        Console.WriteLine("Number of digits: " + count);
    }
}