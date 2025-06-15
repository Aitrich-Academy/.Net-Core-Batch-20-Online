using ConsoleApp2.Modal;

internal class Program
{
    private static void Main(string[] args)
    {
       
        var db = new AppDbContent();
        db.Products.Add(new Product { Name = "phone", Price = 999.9 });
        db.SaveChanges();
        var products = db.Products.ToList();
        foreach(var product in products)
        {
            Console.WriteLine(product.Name);
            Console.WriteLine(product.Price);
        }

    }
}