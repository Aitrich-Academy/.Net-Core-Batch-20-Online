using Car_oops;

internal class Program
{
    private static void Main(string[] args)
    {
        Car myCar = new Car();
        myCar.Model = "Swift";
        myCar.Year = 2023;

        myCar.Displayinfo();
    }
}