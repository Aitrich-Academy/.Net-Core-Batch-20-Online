internal class Program
{
    private static void Main(string[] args)
    {

        Console.WriteLine("Choose a shape to calculate area:");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Rectangle");
        Console.WriteLine("3. Triangle");
        Console.Write("Enter your choice (1-3): ");

        int choice = Convert.ToInt32(Console.ReadLine());
        double area = 0;

        switch (choice)
        {
            case 1:
                Console.Write("Enter the radius of the circle: ");
                double radius = Convert.ToDouble(Console.ReadLine());
                area = Math.PI * radius * radius;
                break;

            case 2:
                Console.Write("Enter the length of the rectangle: ");
                double length = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the width of the rectangle: ");
                double width = Convert.ToDouble(Console.ReadLine());
                area = length * width;
                break;

            case 3:
                Console.Write("Enter the base of the triangle: ");
                double baseLength = Convert.ToDouble(Console.ReadLine());
                Console.Write("Enter the height of the triangle: ");
                double height = Convert.ToDouble(Console.ReadLine());
                area = 0.5 * baseLength * height;
                break;

            default:
                Console.WriteLine("Invalid choice!");
                return;
        }

        Console.WriteLine($"The calculated area is: {area}");
    }
}