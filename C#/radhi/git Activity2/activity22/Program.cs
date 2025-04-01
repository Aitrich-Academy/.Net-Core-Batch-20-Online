internal class Program
{
    private static void Main(string[] args)
    {
        int count=0;
        Console.WriteLine("enter a string");
        string words=Console.ReadLine();

        foreach (var item in words)
        {
            if (item == 'a' || item == 'e' || item == 'i' || item == 'o' || item == 'u')
            {
                count++;
            }

            
        }
        Console.WriteLine(count);



    }
}