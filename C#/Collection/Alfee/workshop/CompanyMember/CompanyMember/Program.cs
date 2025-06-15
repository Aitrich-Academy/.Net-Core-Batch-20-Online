using CompanyMember.Interfaces;
using CompanyMember.Manager;

    public class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new CompanyManager();
            menu.DisplayMenu();
        }
    }
