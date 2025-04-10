 internal class Program
{
    struct Job
    {
        public int Id;
        public string Title;
        public string Experience;
        public string Company;
        public string Location;
        public string Salary;
    }

    static void Main()
    {
        string email = "", password = "";
        List<Job> jobs = new List<Job>
        {
            new Job { Id = 1, Title = "Software Engineer", Experience = "3+ years", Company = "Acme Inc.", Location = "New York", Salary = "$100,000 - $150,000" },
            new Job { Id = 2, Title = "Product Manager", Experience = "5+ years", Company = "Globex Corp.", Location = "San Francisco", Salary = "$120,000 - $180,000" },
            new Job { Id = 3, Title = "System Manager", Experience = "2+ years", Company = "Hooli Enterprises", Location = "Seattle", Salary = "$70,000 - $90,000" }
        };

        string mainChoice;
        do
        {
            Console.WriteLine("Welcome to the job portal!");
            Console.WriteLine("A. Register");
            Console.WriteLine("B. Login");
            Console.Write("Enter your choice: ");
            string option = Console.ReadLine().ToUpper();

            switch (option)
            {
                case "A":
                    Console.WriteLine("Registration successful!");
                    Console.Write("Please enter your email: ");
                    email = Console.ReadLine();
                    Console.Write("Please enter your password: ");
                    password = Console.ReadLine();
                    break;

                case "B":
                    Console.Write("Please enter your email: ");
                    string loginEmail = Console.ReadLine();
                    Console.Write("Please enter your password: ");
                    string loginPassword = Console.ReadLine();

                    switch (loginEmail == email && loginPassword == password)
                    {
                        case true:
                            Console.WriteLine("Login successful!");
                            Console.WriteLine($"Welcome {loginEmail.Split('@')[0]}!");

                            string subChoice;
                            do
                            {
                                Console.WriteLine("1. List all jobs");
                                Console.WriteLine("2. My profile");
                                Console.WriteLine("3. Logout");
                                Console.Write("Enter your choice: ");
                                string menuChoice = Console.ReadLine();

                                switch (menuChoice)
                                {
                                    case "1":
                                        Console.WriteLine("Jobs available:");
                                        Console.WriteLine("ID  Title                Experience   Company           Location             Salary Range");
                                        foreach (var job in jobs)
                                        {
                                            Console.WriteLine($"{job.Id,-3} {job.Title,-20} {job.Experience,-12} {job.Company,-18} {job.Location,-20} {job.Salary}");
                                        }
                                        break;

                                    case "2":
                                        Console.WriteLine("My Profile:");
                                        Console.WriteLine("Email: " + email);
                                        break;

                                    case "3":
                                        Console.WriteLine("Logged out successfully!");
                                        break;
                                }

                                Console.Write("Do you want to continue in login menu? (Y/N): ");
                                subChoice = Console.ReadLine().ToUpper();
                            } while (subChoice == "Y");
                            break;

                        case false:
                            Console.WriteLine("Login failed! Incorrect details.");
                            break;
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option!");
                    break;
            }

            Console.Write("Do you want to return to the main menu? (Y/N): ");
            mainChoice = Console.ReadLine().ToUpper();

        } while (mainChoice == "Y");

        Console.WriteLine("Thank you for using the job portal!");
    }
}