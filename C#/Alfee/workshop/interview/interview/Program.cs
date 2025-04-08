namespace InterviewScheduler
{
    class Program
    {
        // Struct to store interview details
        struct Interview
        {
            public string JobTitle;
            public string Date;
            public string Time;
            public string Location;
        }

        static void Main(string[] args)
        {
            List<Interview> interviewList = new List<Interview>();
            char choice;
            char continueChoice;

            Console.WriteLine("=== Job Interview Scheduler ===");

            do
            {
                
                Console.WriteLine("\nMenu:");
                Console.WriteLine("A - Schedule a Job Interview");
                Console.WriteLine("D - Display All Scheduled Interviews");
                Console.Write("Enter your choice: ");
                choice = Convert.ToChar(Console.ReadLine().ToUpper());

                switch (choice)
                {
                    case 'A':
                        Interview interview = new Interview();

                        Console.WriteLine("\n--- Schedule Interview ---");
                        Console.Write("Enter Job Title: ");
                        interview.JobTitle = Console.ReadLine();
                        Console.Write("Enter Date: ");
                        interview.Date = Console.ReadLine();
                        Console.Write("Enter Time : ");
                        interview.Time = Console.ReadLine();
                        Console.Write("Enter Location: ");
                        interview.Location = Console.ReadLine();

                        interviewList.Add(interview);
                        Console.WriteLine("✅ Interview scheduled successfully.");
                        break;

                    case 'D':
                        Console.WriteLine("\n--- Scheduled Interviews ---");

                        switch (interviewList.Count)
                        {
                            case 0:
                                Console.WriteLine("⚠️ No interviews scheduled yet.");
                                break;

                            default:
                                for (int i = 0; i < interviewList.Count; i++)
                                {
                                    Console.WriteLine($"\nInterview {i + 1}:");
                                    Console.WriteLine("Job Title : " + interviewList[i].JobTitle);
                                    Console.WriteLine("Date      : " + interviewList[i].Date);
                                    Console.WriteLine("Time      : " + interviewList[i].Time);
                                    Console.WriteLine("Location  : " + interviewList[i].Location);
                                }
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("❌ Invalid option. Please enter 'A' or 'D'.");
                        break;
                }

                Console.Write("\nDo you want to continue? (Y/N): ");
                continueChoice = Convert.ToChar(Console.ReadLine().ToUpper());

            } while (continueChoice == 'Y');

            Console.WriteLine("Thank you for using the Interview Scheduler. Goodbye!");
        }
    }
}