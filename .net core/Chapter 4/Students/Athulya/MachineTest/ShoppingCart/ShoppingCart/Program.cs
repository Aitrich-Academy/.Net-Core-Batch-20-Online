
namespace ShoppingCart
{
    public  class Program
    {

        static void Main(string[] args)
        {


            bool exit = false;
            int option;
            ShoppingCart cart = new ShoppingCart();

            while (!exit)
            {
                Console.WriteLine("Please select  option ");
                Console.WriteLine("................................");
                Console.WriteLine("1.Add Item");
                Console.WriteLine("2.Remove Item ");
                Console.WriteLine("3.Discount ");
                Console.WriteLine("4.Total price");
                Console.WriteLine("5.Display Items");
                Console.WriteLine("6.Exit");
                try
                {
                    option = Convert.ToInt32(Console.ReadLine());


                    switch (option)
                    {
                        case 1:

                            cart.AddItem();

                            break;
                        case 2:
                            cart.RemoveItem();
                            break;
                        case 3:
                            cart.CalculateDiscount();
                            break;
                        case 4:
                            cart.CalculatePrice();
                            break;
                        case 5:
                            cart.DisplayItems();
                            break;
                        case 6:
                            exit = true;
                            Console.WriteLine("Exit");
                            break;
                        default:
                            Console.WriteLine("Invalid");
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Try again");
                    exit = false;
                }
            }
        }
    }
}







