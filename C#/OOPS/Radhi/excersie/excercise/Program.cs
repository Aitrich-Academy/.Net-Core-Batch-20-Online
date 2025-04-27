using project.Managers;

internal class Program
{
    private static void Main(string[] args)
    {
        bool exitProgram = false;
        PublicManager p = new PublicManager();

        while (!exitProgram)
        {
            Console.WriteLine("Welcome To Hire Me Now!");
            Console.WriteLine();
            p.Show_main_menu();
        }
    }
}