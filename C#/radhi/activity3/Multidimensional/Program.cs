using System.Transactions;

internal class Program
{
    private static void Main(string[] args)
    {
        int[,] number = new int[3, 3];
        Console.WriteLine("enter the numbers");

        for(int i=0;i<3;i++)
        {
           for(int j=0;j<3;j++)
            {
                number[i, j] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\t");
            }
           Console.Write("\n");
          
        }

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(number[i,j] +"\t");
                
            }
            Console.WriteLine("\n");
           
        }


    }
}