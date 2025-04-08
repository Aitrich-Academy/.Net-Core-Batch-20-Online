internal class Program
{
    private static void Main(string[] args)
    {
        string[,] country = new string[3, 3];

        country[0, 0] = "India";
        country[0, 1] = "Africa";
        country[0, 2] = "America";
        country[1, 0] = "Australia";
        country[1, 1] = "Canada";
        country[1, 2] = "Italy";
        country[2, 0] = "Japan";
        country[2, 1] = "China";
        country[2, 2] = "England";

        for(int i = 0; i < 3; i++)
        {
            for(int j = 0; j < 3; j++)
            {
                Console.WriteLine(country[i, j]);
            }
            Console.WriteLine();
        }
        Console.ReadLine();
    }
}