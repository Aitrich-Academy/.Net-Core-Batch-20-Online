internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 12, 5, 8, 19, 3, 7 }; // Sample vector
        int smallest = int.MaxValue; // Initialize with the largest possible integer value

        foreach (int num in numbers)
        {
            if (num < smallest)
            {
                smallest = num;
            }
        }

        Console.WriteLine("The smallest number in the vector is: " + smallest);
    }
}