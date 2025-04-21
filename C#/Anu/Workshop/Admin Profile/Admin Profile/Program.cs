internal class Program
{

    struct AdminProfile
    {
        public string Name;
        public string Username;
        public string Email;
        public string PhoneNumber;
    }
    private static void Main(string[] args)
    {
        AdminProfile admin = new AdminProfile();
        bool isAdminRegistered = false;
        string userChoice;

        Console.WriteLine("=== Welcome to the Admin Section ===");
        do
        {
            Console.WriteLine("\nPlease select an option:");
            Console.WriteLine("A - Register as Admin");
            Console.WriteLine("D - Display Admin Details");
            Console.Write("Your choice: ");
            string option = Console.ReadLine();

            switch (option.ToUpper())
            {
                case "A":
                    Console.Write("Enter Admin Name: ");
                    admin.Name = Console.ReadLine();

                    Console.Write("Enter Username: ");
                    admin.Username = Console.ReadLine();

                    Console.Write("Enter Email: ");
                    admin.Email = Console.ReadLine();

                    Console.Write("Enter Phone Number: ");
                    admin.PhoneNumber = Console.ReadLine();

                    isAdminRegistered = true;
                    Console.WriteLine("Admin registered successfully!");
                    break;

                case "D":
                    if (isAdminRegistered)
                    {
                        Console.WriteLine("\n=== Admin Details ===");
                        Console.WriteLine($"Name       : {admin.Name}");
                        Console.WriteLine($"Username   : {admin.Username}");
                        Console.WriteLine($"Email      : {admin.Email}");
                        Console.WriteLine($"Phone No.  : {admin.PhoneNumber}");
                    }
                    else
                    {
                        Console.WriteLine("No admin registered yet. Please register first.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid option. Please select 'A' or 'D'.");
                    break;
            }

            Console.Write("\nDo you want to continue? (Y/N): ");
            userChoice = Console.ReadLine();

        } while (userChoice.Equals("Y", StringComparison.OrdinalIgnoreCase));

        Console.WriteLine("Thank you for using the Admin Profile Manager!");
    }
}
    
