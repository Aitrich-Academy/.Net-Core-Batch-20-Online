using JobApplication.Manager;

internal class Program
{
    private static void Main(string[] args)
    {
        bool exitProgram = false;
        JobSeekerManager seekerManager = new JobSeekerManager();

        while (!exitProgram)
        {
            Console.WriteLine(" Welcome To Hire Me Now! \t The jobseeker portal!");
            seekerManager.ShowMainMenu();
        }
    }
}