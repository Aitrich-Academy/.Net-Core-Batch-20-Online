using System.ComponentModel.Design;
using JobProviderModule.Interface;

namespace JobProviderModule
{
    internal class Program
    {
        public static void Main(string[] args)

        {
            IMenu menu = new PublicManager();
            _ = NewMethod(menu);
        }

        private static void NewMethod(IMenu menu)
        {
            menu.DisplayMenu();
        }
    }
}