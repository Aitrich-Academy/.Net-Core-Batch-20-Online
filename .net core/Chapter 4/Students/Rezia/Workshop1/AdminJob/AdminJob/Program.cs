using AdminJob.Interface;
using AdminJob.Manager;

namespace AdminJob
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