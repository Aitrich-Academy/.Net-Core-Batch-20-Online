using Appliencess;

public class Program
{
    private static void Main(string[] args)
    {
       Refigerator applience= new Refigerator();
        WashingMachine machine= new WashingMachine();   
        
        Console.WriteLine("Testing WashingMachine:");
        applience.Turnon();
        applience.Turnoff();

        Console.WriteLine("\nTesting Refrigerator:");
       machine.Turnon();
       machine.Turnoff();

    }
}