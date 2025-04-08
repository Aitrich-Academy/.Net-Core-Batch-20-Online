internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        string input = Console.ReadLine();
        string result = "";

        int i = 0;
        while (i < input.Length)
        {
            char digit = input[i];
            if (digit % 2 != 0) // Check if the digit is odd
            {
                result += digit;
            }
            i++;
        }

        Console.WriteLine("Number after removing even digits: " + (result == "" ? "0" : result));
    }
}