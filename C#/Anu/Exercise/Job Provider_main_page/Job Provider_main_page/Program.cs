internal class Program
{
    struct Job
    {
        public int ID;
        public string Title;
        public string Experience;
        public string Company;
        public string Location;
        public string SalaryRange;
    }

    struct User
    {
        public string Username;
        public string Email;
        public string Password;
    }
    private static void Main(string[] args)
    {
        List<User> registeredUsers = new List<User>();
        User currentUser = new User();
        bool isLoggedIn = false;

        Job[] jobs = new Job[]
        {
            new Job { ID = 1, Title = "Software Engineer", Experience = "3+ years", Company = "Acme Inc.", Location = "New York, NY", SalaryRange = "$100,000 - $150,000" },
            new Job { ID = 2, Title = "Product Manager", Experience = "5+ years", Company = "Globex Corp.", Location = "San Francisco, CA", SalaryRange = "$120,000 - $180,000" },
            new Job { ID = 3, Title = "Marketing Specialist", Experience = "2+ years", Company = "Hooli Enterprises", Location = "Seattle, WA", SalaryRange = "$70,000 - $90,000" }
        };

        while (true)
        {
            Console.WriteLine("\nWelcome to the job portal!");
            Console.WriteLine("1. Register\n2. Login\n3. Exit");

            int mainChoice = int.Parse(Console.ReadLine());

            switch (mainChoice)
            {
                case 1:
                    Console.Write("Enter username: ");
                    string regUsername = Console.ReadLine();
                    Console.Write("Enter email: ");
                    string regEmail = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string regPassword = Console.ReadLine();

                    // Save user
                    registeredUsers.Add(new User
                    {
                        Username = regUsername,
                        Email = regEmail,
                        Password = regPassword
                    });

                    Console.WriteLine("Registration successful!");
                    break;

                case 2:
                    Console.Write("Enter email: ");
                    string loginEmail = Console.ReadLine();
                    Console.Write("Enter password: ");
                    string loginPassword = Console.ReadLine();

                    bool found = false;
                    foreach (var user in registeredUsers)
                    {
                        if (user.Email == loginEmail && user.Password == loginPassword)
                        {
                            isLoggedIn = true;
                            currentUser = user;
                            found = true;
                            Console.WriteLine($"Login successful! Welcome {user.Username}!");
                            break;
                        }
                    }

                    if (!found)
                    {
                        Console.WriteLine("Invalid email or password.");
                        break;
                    }

                    while (isLoggedIn)
                    {
                        Console.WriteLine("\n1. List all jobs\n2. My profile\n3. Logout");
                        int userChoice = int.Parse(Console.ReadLine());

                        switch (userChoice)
                        {
                            case 1:
                                Console.WriteLine("Jobs available:");
                                Console.WriteLine("ID\tTitle\t\t\tExperience\tCompany\t\t\tLocation\t\tSalary Range");
                                foreach (var job in jobs)
                                {
                                    Console.WriteLine($"{job.ID}\t{job.Title.PadRight(20)}\t{job.Experience.PadRight(10)}\t{job.Company.PadRight(20)}\t{job.Location.PadRight(15)}\t{job.SalaryRange}");
                                }
                                break;

                            case 2:
                                Console.WriteLine($"\nUsername: {currentUser.Username}");
                                Console.WriteLine($"Email: {currentUser.Email}");
                                break;

                            case 3:
                                Console.WriteLine("Logged out successfully!");
                                isLoggedIn = false;
                                break;

                            default:
                                Console.WriteLine("Invalid choice.");
                                break;
                        }
                    }
                    break;

                case 3:
                    Console.WriteLine("Exiting the portal. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }
    }
}
    
