internal class Program
{
    private static void Main(string[] args)
    {
        // Create and initialize a 3x3 matrix
        int[,] matrix = new int[3, 3]
        {
            { 1, 2, 3 },
            { 4, 5, 6 },
            { 7, 8, 9 }
        };

        // Display the matrix elements
        Console.WriteLine("The 3x3 matrix is:");
        for (int i = 0; i < 3; i++) // rows
        {
            for (int j = 0; j < 3; j++) // columns
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
    
