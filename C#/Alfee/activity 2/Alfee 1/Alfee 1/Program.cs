internal class Program
{
    private static void Main(string[] args)
    {
        int num = 2;
        do
        {
            Console.Write(num + " ");
            num += 2;
        } while (num <= 20);
        Console.WriteLine();
    }
}