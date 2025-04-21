using E_commerce;

internal class Program
{
    private static void Main(string[] args)
    {
        Electronic laptop = new Electronic("Laptop", 1000,"Dell");
        Cloth shirt = new Cloth("Shirt",50,"M", "Cotton");

        
        laptop.GetProductDetails();
        laptop.Showprice();
        laptop.CalculateDiscount();

        Console.WriteLine();

       
        shirt.GetProductDetails();
        shirt.Showprice();
        shirt.CalculateDiscount();
    }
}