using Product_management;

internal class Program
{
    private static void Main(string[] args)
    {
        Product[]p=new Product[10];
        p[0] = new Product(4, "Smartwatch", 199);
        p[1] = new Product(1, "laptop", 19);
        p[2] = new Product(6, "car", 20);
        for(int i = 0; i < 3; i++)
        {
            p[i].ShowProduct();

        }

        
        
            
        
        
       
            

        

     


    }
}