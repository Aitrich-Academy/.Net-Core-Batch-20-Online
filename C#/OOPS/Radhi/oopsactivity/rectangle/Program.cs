using rectangle;

internal class Program
{
    private static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle();
        rectangle.Length = 10.5;
        rectangle.Width = 23.4;
       double x= rectangle.CalculateArea();
        Console.WriteLine($"Area:{x}");
        
       

       



    }
}