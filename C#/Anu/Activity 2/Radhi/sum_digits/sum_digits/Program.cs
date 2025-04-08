internal class Program
{
    private static void Main(string[] args)
    {
        int[] numbers = { 10, 20, 30, 40, 50 };
        int sum = 0;

        // Using foreach loop to calculate sum
        foreach (int num in numbers)
        {
            sum += num;
        }

        Console.WriteLine("The sum of all elements in the array is: " + sum);
    }
}