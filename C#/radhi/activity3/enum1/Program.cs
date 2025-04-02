using System.ComponentModel;
using System.Xml.Linq;
enum DayOfweek
{
    sunday,
    monday,
    tueday,
    wednesday,
    thursday,
    friday,
    saturday
}

internal class Program
{
    private static void Main(string[] args)
    {
    // Create an enum named DaysOfWeek(Sunday to Saturday).

    //Write a program to display the name and integer value of each day.
       DayOfweek day = DayOfweek.sunday;
        Console.WriteLine(day);
        Console.WriteLine((int)DayOfweek.sunday);

    
            Console.WriteLine((int)day);
                











    }
}