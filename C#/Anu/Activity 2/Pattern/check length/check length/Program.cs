internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter a string: ");
        string inputString = Console.ReadLine();

        int length = inputString.Length;

        Console.WriteLine($"The length of the string is: {length}");
    }
}