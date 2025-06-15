

using JobProvider.Interface;
using JobProvider.Manager;

internal class Program
{
    private static void Main(string[] args)
    {
        IMenu menu = new JobManager();
        menu.DisplayMenu();
    }
}