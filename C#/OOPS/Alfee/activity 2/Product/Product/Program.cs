using Product_oops;
internal class Program
{
    private static void Main(string[] args)
    {
        List<Product> products = new List<Product>()
        {
            new Product(1, "Laptop", 75000),
            new Product(2, "Phone", 40000),
            new Product(3, "Tablet", 25000)
        };

        foreach (Product product in products)
        {
            product.ShowProduct();
        }
    }
}