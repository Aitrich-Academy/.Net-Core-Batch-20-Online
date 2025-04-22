using inheritance_oops;

internal class Program
{
    private static void Main(string[] args)
    {
        Childclass child1 = new Childclass();
        child1.Makecall();
        child1.Os="Android";
        child1.displayname();
    }
}