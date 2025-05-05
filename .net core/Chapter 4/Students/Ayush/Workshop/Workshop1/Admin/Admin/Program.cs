using Admin.Interfaces;
using Admin.Manager;

namespace Admin
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IMenu menu = new PublicManager();
            menu.Displaymenu();

        }
    }
}