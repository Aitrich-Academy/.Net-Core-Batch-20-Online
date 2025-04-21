using Event_Scheduler;
internal class Program

{
    private static void Main(string[] args)
    {
       
       
        Event e=new Event ("aly","20-10-1994","lil");
        Event e1 = new Event("weding", "20-3-2025", "kochi");
        Event e2 = new Event("naming", "2-4-2025", "kochi");
        e.Display();
        e1.Display();
        e2.Display();


    }
}