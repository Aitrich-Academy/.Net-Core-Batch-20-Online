using bankaccount;
public class Program
{
    private static void Main(string[] args)
    {
        
           
                       
                        Console.Write("Enter Account Number: ");
                        string accNumber = Console.ReadLine();

                        Console.Write("Enter Holder Name: ");
                        string holderName = Console.ReadLine();

                        Console.Write("Enter Initial Balance: ");
                        double balance = double.Parse(Console.ReadLine());
                        Bank b = new Bank(accNumber, holderName, balance);

                  


                        

                        b.DisplayAccount();
                      

                        Console.WriteLine("enter amount to deposite");
                        int amount = Convert.ToInt32(Console.ReadLine());
                          b.Deposit(amount);
        Console.Write("Enter Account Number: ");
        string acNumber = Console.ReadLine();

        Console.Write("Enter Holder Name: ");
        string holdername = Console.ReadLine();

        Console.Write("Enter Initial Balance: ");
        double bal = double.Parse(Console.ReadLine());
        Bank b1 = new Bank(acNumber, holdername, bal);
        b1.DisplayAccount();


        Console.WriteLine("enter amount to deposite");
        int amounts = Convert.ToInt32(Console.ReadLine());
        b.Deposit(amounts);








    }
}