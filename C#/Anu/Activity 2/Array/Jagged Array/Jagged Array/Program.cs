internal class Program
{
    private static void Main(string[] args)
    {
        // Create a jagged array with 3 rows
        int[][] jaggedArray = new int[3][];

        // Initialize each row with a different number of elements
        jaggedArray[0] = new int[2] { 1, 2 };        // Row 1 with 2 elements
        jaggedArray[1] = new int[3] { 3, 4, 5 };     // Row 2 with 3 elements
        jaggedArray[2] = new int[1] { 6 };           // Row 3 with 1 element

        // Print all elements of the jagged array
        Console.WriteLine("Jagged Array Elements:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            Console.Write("Row " + (i + 1) + ": ");
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}