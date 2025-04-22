using display_car;

internal class Program
{
    private static void Main(string[] args)
    {
        Car mycar1 = new Car();
        mycar1.Model = "Toyota Corola";
        mycar1.Year = 2025;

        mycar1.DisplayInfo();

        Car mycar2 = new Car();
        mycar2.Model = "Honda Civic";
        mycar2.Year = 2024;

        mycar2.DisplayInfo();
    }
}