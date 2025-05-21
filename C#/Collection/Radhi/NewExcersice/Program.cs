using NewExcersice.Enum;
using NewExcersice.Manager;
using NewExcersice.Model;
using NewExcersice.Repository;
using static NewExcersice.Repository.AppliedJobRepository;

internal class Program
{
    private static void Main(string[] args)
    {
        var userRepo = new UserRepository();
        var jobRepo = new JobRepository();
        var appliedRepo = new AppliedJobRepository();
        var savedRepo = new SavedJobRepository();

        var userManager = new UserManager(userRepo);
        var jobManager = new JobManager(jobRepo);

        User currentUser = null;

        while (true)
        {
            Console.WriteLine("\nChoose an option:");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Register");
            Console.WriteLine("3. Exit");
            Console.Write("Choose any option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter your email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter your password: ");
                    string password = Console.ReadLine();

                    currentUser = userManager.Login(email, password);
                    if (currentUser != null)
                    {
                        Console.WriteLine($"\nLogin successful!\nWelcome {currentUser.FirstName}");

                        bool isLoggedIn = true;

                        while (isLoggedIn)
                        {
                            Console.WriteLine("\nAre you:");
                            Console.WriteLine("1. Job Provider");
                            Console.WriteLine("2. Job Seeker");
                            Console.WriteLine("3. Logout");
                            Console.Write("Choose any option: ");
                            string roleChoice = Console.ReadLine();

                            switch (roleChoice)
                            {
                                case "1": // Job Provider
                                    bool inProviderMenu = true;
                                    while (inProviderMenu)
                                    {
                                        Console.WriteLine("\nJob Provider Menu:");
                                        Console.WriteLine("1. Post job");
                                        Console.WriteLine("2. List jobs");
                                        Console.WriteLine("3. Back to role selection");
                                        Console.Write("Choose any option: ");
                                        string providerChoice = Console.ReadLine();

                                        switch (providerChoice)
                                        {
                                            case "1":
                                                Job newJob = new Job();
                                                Console.Write("Enter Job title: ");
                                                newJob.Title = Console.ReadLine();
                                                Console.Write("Enter Job description: ");
                                                newJob.Description = Console.ReadLine();
                                                Console.Write("Enter Job location: ");
                                                newJob.Location = Console.ReadLine();
                                                Console.Write("Enter Job type (Online/Offline/Hybrid): ");
                                                newJob.roles = Enum.Parse<Roles>(Console.ReadLine(), true);
                                                Console.Write("Enter Job salary range: ");
                                                newJob.SalaryRange = Convert.ToDecimal(Console.ReadLine());
                                                Console.Write("Enter Job company: ");
                                                newJob.Company = Console.ReadLine();

                                                jobManager.PostJob(newJob);
                                                Console.WriteLine("Job posted successfully.");
                                                break;

                                            case "2":
                                                var jobs = jobManager.GetJobs();
                                                foreach (var job in jobs)
                                                {
                                                    Console.WriteLine($"\nJobId: {job.JobId}, Title: {job.Title}, Type: {job.roles}, Description: {job.Description}, Company: {job.Company}, Location: {job.Location}, Salary: {job.SalaryRange}");
                                                }
                                                break;

                                            case "3":
                                                inProviderMenu = false;
                                                break;

                                            default:
                                                Console.WriteLine("Invalid option.");
                                                break;
                                        }
                                    }
                                    break;

                                case "2": // Job Seeker
                                    bool inSeekerMenu = true;
                                    while (inSeekerMenu)
                                    {
                                        Console.WriteLine("\nJob Seeker Menu:");
                                        Console.WriteLine("1. List all jobs");
                                        Console.WriteLine("2. Saved Jobs");
                                        Console.WriteLine("3. Applied Jobs");
                                        Console.WriteLine("4. My Profile");
                                        Console.WriteLine("5. Back to role selection");
                                        Console.Write("Choose any option: ");
                                        string seekerChoice = Console.ReadLine();

                                        switch (seekerChoice)
                                        {
                                            case "1":
                                                var jobs = jobManager.GetJobs();
                                                foreach (var job in jobs)
                                                {
                                                    Console.WriteLine($"\nJobId: {job.JobId}, Title: {job.Title}, Type: {job.SalaryRange}, Description: {job.Description}, Company: {job.Company}, Location: {job.Location}, Salary: {job.SalaryRange}");
                                                }

                                                Console.WriteLine("\n1. Apply to a job\n2. Save a job\n3. Back");
                                                string action = Console.ReadLine();

                                                if (action == "1")
                                                {
                                                    Console.Write("Enter JobId to apply: ");
                                                    int jobId = Convert.ToInt32(Console.ReadLine());
                                                    appliedRepo.ApplyJob(currentUser.Id, jobId);
                                                    Console.WriteLine("Job applied successfully.");
                                                }
                                                else if (action == "2")
                                                {
                                                    Console.Write("Enter JobId to save: ");
                                                    int jobId = Convert.ToInt32(Console.ReadLine());
                                                    savedRepo.SaveJob(currentUser.Id, jobId);
                                                    Console.WriteLine("Job saved successfully.");
                                                }
                                                break;

                                            case "2":
                                                var savedJobs = savedRepo.GetSavedJobs(currentUser.Id);
                                                Console.WriteLine("\nSaved Jobs:");
                                                foreach (var sJob in savedJobs)
                                                {
                                                    var job = jobManager.GetJobById(sJob.JobId);
                                                    Console.WriteLine($"JobId: {job.JobId}, Title: {job.Title}, Company: {job.Company}");
                                                }
                                                break;

                                            case "3":
                                                var appliedJobs = appliedRepo.GetAppliedJobs(currentUser.Id);
                                                Console.WriteLine("\nApplied Jobs:");
                                                foreach (var aJob in appliedJobs)
                                                {
                                                    var job = jobManager.GetJobById(aJob.JobId);
                                                    Console.WriteLine($"JobId: {job.JobId}, Title: {job.Title}, Company: {job.Company}");
                                                }
                                                break;

                                            case "4":
                                                Console.WriteLine($"\nName: {currentUser.FirstName} {currentUser.LastName}\nEmail: {currentUser.Email}\nPhone: {currentUser.PhoneNumber}");
                                                break;

                                            case "5":
                                                inSeekerMenu = false;
                                                break;

                                            default:
                                                Console.WriteLine("Invalid option.");
                                                break;
                                        }
                                    }
                                    break;

                                case "3":
                                    isLoggedIn = false;
                                    Console.WriteLine("Logged out.");
                                    break;

                                default:
                                    Console.WriteLine("Invalid option.");
                                    break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid credentials.");
                    }
                    break;

                case "2":
                    User newUser = new User();
                    Console.Write("Enter first name: ");
                    newUser.FirstName = Console.ReadLine();
                    Console.Write("Enter last name: ");
                    newUser.LastName = Console.ReadLine();
                    Console.Write("Enter email: ");
                    newUser.Email = Console.ReadLine();
                    Console.Write("Enter phone number: ");
                    newUser.PhoneNumber = Console.ReadLine();
                    Console.Write("Enter password: ");
                    newUser.Password = Console.ReadLine();

                    userManager.Register(newUser);
                    Console.WriteLine("Registration successful.");
                    break;

                case "3":
                    Console.WriteLine("Exiting Job Portal. Goodbye!");
                    return;

                default:
                    Console.WriteLine("Invalid option.");
                    break;
            }
        }

    }

}