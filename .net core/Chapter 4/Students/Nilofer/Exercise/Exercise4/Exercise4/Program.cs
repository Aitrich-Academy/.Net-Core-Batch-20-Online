using Exercise4.Interfaces;
using Exercise4.Managers;

internal class Program
{
    private static void Main(string[] args)
    {
       
            IMenu menu = new CompanyManager();
            menu.DisplayMenu();
        
    }
}