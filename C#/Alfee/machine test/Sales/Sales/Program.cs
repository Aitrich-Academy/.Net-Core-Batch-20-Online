internal class Program
{
    private static void Main(string[] args)
    {
        double[] sales = new double[7];
        double total = 0;
        int highestIndex = 0, lowestIndex = 0;

        for (int i = 0; i < 7; i++)
        {
            Console.Write(" enter sales for the day " + (i + 1) + " : ");
            sales[i] = Convert.ToDouble(Console.ReadLine());
            total += sales[i];
        }

        double highest = sales[0];
        double lowest = sales[0];

        for (int i = 1; i < 7; i++)
        {
            if (sales[i] > highest)
            {
                highest = sales[i];
                highestIndex = i;
            }

            if (sales[i] < lowest)
            {
                lowest = sales[i];
                lowestIndex = i;
            }
        }

        Console.WriteLine(" Total sales of days : " + total);
        Console.WriteLine(" Average sales of days : " + (total / 7));
        Console.WriteLine(" Highest sales of day is : " + highest + " on day " + (highestIndex + 1));
        Console.WriteLine(" Lowest  sales of days : " + lowest + " on day " + (lowestIndex + 1));

    }
}