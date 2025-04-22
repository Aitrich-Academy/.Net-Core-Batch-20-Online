using HouseBlueprint;
internal class Program
{
 public static void Main(string[] args)
    {
        House h = new House("red",4,"aabc");
        House h1 = new House("white", 1, "bc");
        House h2 = new House("Blue", 2, "dc");
        h.Showinfo();
        h1.Showinfo();
        h2.Showinfo();



    }
}