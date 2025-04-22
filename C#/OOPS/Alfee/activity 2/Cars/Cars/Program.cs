using Cars_oops;
internal class Program
{
    private static void Main(string[] args)
    {
        Cars car1 = new Cars();
        Cars car2 = new Cars("Toyota", "Camry", 2022);

        car1.DisplayCars();
        car2.DisplayCars();
    }
}