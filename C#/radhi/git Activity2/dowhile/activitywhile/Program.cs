using System.ComponentModel.Design;
using System.Threading.Tasks;

internal class Program
{
    private static void Main(string[] args)
    {
       int  crnt_balance = 1000;

        Console.WriteLine("Your current Balance:"+crnt_balance);


        while (crnt_balance > 0)
        {

            Console.WriteLine("enter a amount to withdraw or 0 to exit");
            int amount = Convert.ToInt32(Console.ReadLine());
            if (amount <= crnt_balance && amount !=0)
            {

                crnt_balance -= amount;
                Console.WriteLine("Withdrawal successful.Remaining balance:" + crnt_balance);


            }

           
            else if(amount==0)
            {
                Console.WriteLine("Thank you for using the ATM.");
                break;

            }
            else
            {

                Console.WriteLine("Insufficient funds. Please enter a smaller amount.");

            }






        }

       
       


    }
}