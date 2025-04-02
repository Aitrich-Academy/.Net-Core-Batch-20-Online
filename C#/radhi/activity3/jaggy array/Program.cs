internal class Program
{
    private static void Main(string[] args)
    {
        int[][] jaggedArray = new int[3][];
        jaggedArray[0] = new int[2]; // Row 1 has 2 elements
        jaggedArray[1] = new int[3]; // Row 2 has 3 elements
        jaggedArray[2] = new int[1]; // Row 3 has 1 element

        // Input values for the jagged array
        Console.WriteLine("Enter values for the jagged array:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write($"Enter value for jaggedArray[{i}][{j}]: ");
                jaggedArray[i][j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Print the jagged array
        Console.WriteLine("\nJagged Array Elements:");
        for (int i = 0; i < jaggedArray.Length; i++)
        {
            for (int j = 0; j < jaggedArray[i].Length; j++)
            {
                Console.Write(jaggedArray[i][j] + " ");
            }
            Console.WriteLine(); // Move to the next row
        }
    }
}
    
