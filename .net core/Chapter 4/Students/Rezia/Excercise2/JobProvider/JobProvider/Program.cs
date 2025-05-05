using JobProvider.Interface;
using JobProvider.Manaager;

internal class Program
{
    private static void Main(string[] args)
    {
        IMenu menu = new PublicManager();
        menu.DisplayMenu();
    }
}