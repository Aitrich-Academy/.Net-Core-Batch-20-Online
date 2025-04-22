using Rectangle_oops;
internal class Program
{
    private static void Main(string[] args)
    {
        Rectangle rect = new Rectangle();
        rect.Length = 10;
        rect.Width = 20;

        double area = rect.CalculateArea();
        Console.WriteLine("Rectangle area is :" + area);
    }
}