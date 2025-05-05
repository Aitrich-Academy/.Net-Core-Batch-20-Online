using CompanyMember.Interfaces;
using CompanyMember.Manager;

internal class Program
{
    private static void Main(string[] args)
    {
        IMenu menu = new CompanyManager();
        menu.DisplayMenu();
    }
}