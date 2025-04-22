using House_oops;

internal class Program
{
    private static void Main(string[] args)
    {
        House house1 = new House("Red", 3, true);
        House house2 = new House("Green", 4, false);
        House house3 = new House("Yellow", 6, true);

        house1.ShowInfo();
        house2.ShowInfo();
        house3.ShowInfo();
    }
}