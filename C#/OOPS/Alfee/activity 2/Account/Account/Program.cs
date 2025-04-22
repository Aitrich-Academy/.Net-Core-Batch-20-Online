using Account_oops;
internal class Program
{
    private static void Main(string[] args)
    {
        Account acc1 = new Account(101, "Alfiya", 5000);
        Account acc2 = new Account(102, "Anzal", 10000);

        acc1.DisplayAccount();
        acc1.Deposit(1500);
        acc1.DisplayAccount();

        acc2.DisplayAccount();
        acc2.Deposit(2000);
        acc2.DisplayAccount();


    }
}