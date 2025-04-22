using car_inventory;
internal class Program
{
    private static void Main(string[] args)
    {
       Car car1 = new Car("Maruthj","I10","2025");
        Car c = new Car();
        c.DisplayCar();
        car1.DisplayCar();
    }
}