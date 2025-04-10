internal class Program
{
    private static void Main(string[] args)
    {
        //for (int i = 1; i <= 10; i++)
        //{
        //    Console.WriteLine(i);
        //}
        Console.WriteLine("enter any day");
        string day = Console.ReadLine();

        switch(day)
        {
            case "sunday":
                Console.WriteLine("appam");
                break;

            case "monday":
                Console.WriteLine("puttu");
                break;

            case "tuesday":
                Console.WriteLine("pathiri");
                break;

            case "wednesday":
                Console.WriteLine("dosa");
                break;
        }
    }
}