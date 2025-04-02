internal class Program
{
    private static void Main(string[] args)
    {
        //        2.Inverted Right - Angled Triangle
        //*****
        //****
        //***
        //**
        //*
        Console.WriteLine("enter a limit");
         int limit=Convert.ToInt32(Console.ReadLine());

        for (int i = limit; i > 0; i--)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();

           
            
            

        }





    }
}