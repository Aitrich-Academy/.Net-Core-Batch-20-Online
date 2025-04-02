enum TrafficLight
{
    Red,
    Yellow,
    Green
}
internal class Program
{
    private static void Main(string[] args)
    {
        TrafficLight signal = TrafficLight.Red;

        Console.WriteLine("Current Signal: " + signal);

        if (signal == TrafficLight.Red)
        {
            Console.WriteLine("Stop!");
        }
        else if (signal == TrafficLight.Yellow)
        {
            Console.WriteLine("Get Ready!");
        }
        else
        {
            Console.WriteLine("Go!");
        }

    }
}