internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Enter the number: ");
        int num = int.Parse(Console.ReadLine());

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"{num} * {i} = {num * i}");
        }
    }
}