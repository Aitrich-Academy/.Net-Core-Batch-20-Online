internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Choose a shape to calculate area:");
        Console.WriteLine("1. Circle");
        Console.WriteLine("2. Rectangle");
        Console.WriteLine("3. Triangle");
        Console.Write("Enter your choice (1-3): ");

        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                Console.Write("Enter the radius of the circle: ");
                double radius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * radius * radius;
                Console.WriteLine($"Area of the circle: {circleArea:F2}");
                break;

            case 2:
                Console.Write("Enter the length of the rectangle: ");
                double length = double.Parse(Console.ReadLine());
                Console.Write("Enter the width of the rectangle: ");
                double width = double.Parse(Console.ReadLine());
                double rectangleArea = length * width;
                Console.WriteLine($"Area of the rectangle: {rectangleArea:F2}");
                break;

            case 3:
                Console.Write("Enter the base of the triangle: ");
                double baseLength = double.Parse(Console.ReadLine());
                Console.Write("Enter the height of the triangle: ");
                double height = double.Parse(Console.ReadLine());
                double triangleArea = 0.5 * baseLength * height;
                Console.WriteLine($"Area of the triangle: {triangleArea:F2}");
                break;

            default:
                Console.WriteLine("Invalid choice! Please select a valid option.");
                break;
        }
    }
}