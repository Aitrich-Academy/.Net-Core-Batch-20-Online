internal class Program
{
    private static void Main(string[] args)
    {
        //int a = 10;
        //int b = 0;
        //int c = a / b;
        //Console.WriteLine(c);

        //int[] ints = { 1, 2, 3, 4 };
        //Console.WriteLine(ints[7]);
        try
        {
            int[] array = { 1, 2, 3, 4, 5 };
            Console.WriteLine(array[9]);
        }

        catch(Exception ex)
        {
            Console.WriteLine("ex is : " + ex);
            Console.WriteLine("oops something become error");
        }
    }
}