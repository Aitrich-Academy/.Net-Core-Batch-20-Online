using TransportMode;

internal class Program
{
    private static void Main(string[] args)
    {
        double distance = 480.0;
        Car car = new Car();
        Train train = new Train();
        Airplane airplane = new Airplane();
        car.TravelTime(distance);
        train.TravelTime(distance);
        airplane.TravelTime(distance);  
        Console.WriteLine($"Distance: {distance} km");
        Console.WriteLine($"Car Travel Time: {car.TravelTime(distance)} hours");
        Console.WriteLine($"Train Travel Time: {train.TravelTime(distance)} hours");
        Console.WriteLine($"Airplane Travel Time: {airplane.TravelTime(distance)} hours");

    }
}