internal class Program
{
    private static void Main(string[] args)
    {
        const int maxInterviews = 100;
        string[,] interviews = new string[maxInterviews, 4]; // 4 columns: JobTitle, Date, Time, Location
        int interviewCount = 0;
        char choice;

        Console.WriteLine("Welcome to the Interview Schedule Management System!");

        do
        {
            Console.WriteLine("\nPlease choose an option:");
            Console.WriteLine("A - Schedule an Interview");
            Console.WriteLine("D - Display All Scheduled Interviews");
            Console.WriteLine("E - Exit");

            choice = Char.ToUpper(Convert.ToChar(Console.ReadLine()));

            switch (choice)
            {
                case 'A':
                    if (interviewCount < maxInterviews)
                    {
                        Console.Write("Enter Job Title: ");
                        interviews[interviewCount, 0] = Console.ReadLine();

                        Console.Write("Enter Date (e.g., 2025-04-10): ");
                        interviews[interviewCount, 1] = Console.ReadLine();

                        Console.Write("Enter Time (e.g., 10:30 AM): ");
                        interviews[interviewCount, 2] = Console.ReadLine();

                        Console.Write("Enter Location: ");
                        interviews[interviewCount, 3] = Console.ReadLine();

                        interviewCount++;
                        Console.WriteLine("Interview scheduled successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Interview list is full. Cannot add more.");
                    }
                    break;

                case 'D':
                    if (interviewCount == 0)
                    {
                        Console.WriteLine("No interviews scheduled.");
                    }
                    else
                    {
                        Console.WriteLine("\nScheduled Interviews:");
                        for (int i = 0; i < interviewCount; i++)
                        {
                            Console.WriteLine("-----------------------------------");
                            Console.WriteLine($"Job Title : {interviews[i, 0]}");
                            Console.WriteLine($"Date      : {interviews[i, 1]}");
                            Console.WriteLine($"Time      : {interviews[i, 2]}");
                            Console.WriteLine($"Location  : {interviews[i, 3]}");
                        }
                    }
                    break;

                case 'E':
                    Console.WriteLine("Exiting the program. Goodbye!");
                    break;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }

        } while (choice != 'E');
    }
}
