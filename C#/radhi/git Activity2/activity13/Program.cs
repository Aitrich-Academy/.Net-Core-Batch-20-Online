internal class Program
{
    private static void Main(string[] args)
    {
        int s=0;
        //3. Write a for loop that calculates the sum of all even numbers from 1 to 50. Print the result.
        for (int i = 0; i <= 50; i++)
        {
            if (i % 2 == 0)
            {
                s = i + s;


            }

        }
        Console.WriteLine(s);
    }
}