internal class Program
{
    private static void Main(string[] args)
    {

        // Declare an array to hold 5 integers
        int[] numbers = new int[5];

        // Input: Get 5 integers from the user
        Console.WriteLine("Enter 5 integers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write($"Enter integer {i + 1}: ");
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Output: Display the integers
        Console.WriteLine("\nThe integers you entered are:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"Element {i + 1}: {numbers[i]}");
        }
    }
}
