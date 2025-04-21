internal class Program
{
    private static void Main(string[] args)
    {
      
        string answer;

        do
        {
            for (int i= 0; i< 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("do you want to continue this....?");
            answer = Console.ReadLine();

           

        } while (answer != "no");
        Console.WriteLine("thank you");

    }
}