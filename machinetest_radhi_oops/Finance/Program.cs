using Finance.Model;

internal class Program
{
    private static void Main(string[] args)
    {
        string choice;
        string c;
        do
        {

            AccountManager accountManager = new AccountManager();
            Console.WriteLine("*****Welcome*****");
            Console.WriteLine("Select Account Type");
            Console.WriteLine("1.Savings Account");
            Console.WriteLine("2.Current Account");
            Console.WriteLine("3.Exit");
            Console.WriteLine("enter your choice(1 or 2)");

            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    accountManager.CreateSavingsAccount();
                    break;
                case "2":
                    accountManager.CreateCurrentAccount();
                    break;
                default:
                    Console.WriteLine("Invaid Choice....!");
                    break;

            }

            if (choice! == "3")
            {
                Console.WriteLine("\n press any key to continue");
                Console.ReadLine();
            }
        } while (choice != "3");
                
    }
}