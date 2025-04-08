internal class Program
{
    public enum DaysOfWeek
    {
        Sunday = 1,
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday
    }
    static void Main(string[] args)
    {
       
        foreach (DaysOfWeek day in Enum.GetValues(typeof(DaysOfWeek)))
        {
            
            Console.WriteLine($"Day: {day}, Value: {(int)day}");
        }

        Console.ReadLine();
    }
}