using Event_oops;
internal class Program
{
    private static void Main(string[] args)
    {
        Event event1 = new Event("Seminar Talk", "2025-04-07", "Auditorium A");
        Event event2 = new Event("Presentation", "2025-04-09", "Auditorium B");
        Event event3 = new Event("Cultural Programs", "2025-04-15", "Auditorium C");

        event1.DisplayEvent();
        event2.DisplayEvent();
        event3.DisplayEvent();
    }
}