using WorkshopJobSeeker.Interfaces;
using WorkshopJobSeeker.Manager;

namespace WorkshopJobSeeker
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new PublicManager();
            menu.DisplayMenu();
        }
    }
}
