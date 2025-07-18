using ConsoleApp3.Modals;

internal class Program
{
    private static void Main(string[] args)
    {
        var db = new AppDbContext();
        var db1= new AppDbContext();
        db1.Markers.Add(new Marks { Maths = 40, Science = 45, English = 39 });
        db1.SaveChanges();
        var Markers = db1.Markers.ToList();

    }
}