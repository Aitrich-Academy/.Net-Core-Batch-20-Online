using Products_oops;
internal class Program
{
    private static void Main(string[] args)
    {
        Electronics laptop = new Electronics("Laptop", 60000, "Dell");
        laptop.GetProductDetails();
        laptop.ShowPrice();
        laptop.CalculateDiscount();

        Console.WriteLine();

        Clothing tops = new Clothing("Crop Top", 8000, "ZARA");
        tops.GetProductDetails();
        tops.ShowPrice();
        tops.CalculateDiscount();
    }
}