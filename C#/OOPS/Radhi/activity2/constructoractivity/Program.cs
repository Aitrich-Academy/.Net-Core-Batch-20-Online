enum Dayofweek
{
    sunday,
    monday,
    tuesday,
    wednesday,
    thursday,
    friday,
    saturday

        
}
internal class Program
{
    private static void Main(string[] args)
    {
        Dayofweek today = Dayofweek.wednesday;
        Console.WriteLine("today is " + today);
        Console.WriteLine((int)today);
 
        
       
    }
}