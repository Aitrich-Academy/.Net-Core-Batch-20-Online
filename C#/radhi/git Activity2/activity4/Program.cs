internal class Program
{
    //Write a C# Sharp program that takes four numbers as input to calculate
   // and print the average.
    private static void Main(string[] args)
    {
        int fst;
        Console.WriteLine("enter a four numbers");

      
       
            fst=Convert.ToInt32(Console.ReadLine());
             int snd=Convert.ToInt32(Console.ReadLine());
        int third =Convert.ToInt32(Console.ReadLine());
        int fourth=Convert.ToInt32(Console.ReadLine());
        int average=(fst+snd+third+fourth)/4;
        Console.WriteLine($"Average:{average}");


        
    }
}