using Transport_oops;
internal class Program
{
    private static void Main(string[] args)
    {
        double distance1 = 300;
        double distance2 = 1500;
        double distance3 = 2300;

        Transport car = new Car();
        Transport train = new Train();
        Transport airplane = new Airplane();

        Console.WriteLine($"--- Travel Time for {distance1} km ---");
        car.TravelTime(distance1);
        train.TravelTime(distance1);
        airplane.TravelTime(distance1);

        Console.WriteLine();

        Console.WriteLine($"--- Travel Time for {distance2} km ---");
        car.TravelTime(distance2);
        train.TravelTime(distance2);
        airplane.TravelTime(distance2);

        Console.WriteLine();

        Console.WriteLine($"--- Travel Time for {distance2} km ---");
        car.TravelTime(distance3);
        train.TravelTime(distance3);
        airplane.TravelTime(distance3);


    }
}