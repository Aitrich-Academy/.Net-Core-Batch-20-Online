using workshop.Interfaces;
using workshop.Manager;

internal class Program
{
  
        static void Main(string[] args)
        {
            IMenu menu = new CompanyManager();
            menu.DisplayMenu();
        }
    
}