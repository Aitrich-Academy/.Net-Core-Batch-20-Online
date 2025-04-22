using Calculator_oops;
internal class Program
{
    public static void Main(string[] args)
    {
        Calculator calc = new Calculator();

        Console.WriteLine("Add(2, 3) = " + calc.Add(2, 3));             
        Console.WriteLine("Add(2.5, 3.5) = " + calc.Add(2.5, 3.5));      
        Console.WriteLine("Add(1, 2, 3) = " + calc.Add(1, 2, 3));        
    }
}