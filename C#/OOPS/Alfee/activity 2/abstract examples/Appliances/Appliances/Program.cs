using Appliances_oops;
internal class Program
{
    private static void Main(string[] args)
    {
        WashingMachine machine = new WashingMachine();
        Refrigerator refrigerator = new Refrigerator();

        machine.TurnOn();
        machine.TurnOff();

        Console.WriteLine();

        refrigerator.TurnOn();
        refrigerator.TurnOff();
    }
}