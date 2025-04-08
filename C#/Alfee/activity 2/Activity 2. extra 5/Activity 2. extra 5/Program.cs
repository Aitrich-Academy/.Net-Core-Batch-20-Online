internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        int num = int.Parse(Console.ReadLine());
        int originalNum = num, sum = 0, remainder;
        int digits = num.ToString().Length; // Count number of digits

        while (num > 0)
        {
            remainder = num % 10;
            sum += (int)Math.Pow(remainder, digits);
            num /= 10;
        }

        if (originalNum == sum)
            Console.WriteLine("The number is an Armstrong number.");
        else
            Console.WriteLine("The number is not an Armstrong number.");
    }
}