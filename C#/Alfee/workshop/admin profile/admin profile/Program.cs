
namespace AdminSectionApp
{
    internal class Program
    {
        struct AdminProfile
        {
            public string Name;
            public string Username;
            public string Email;
            public string Phone;
        }

        static void Main(string[] args)
        {
            AdminProfile admin = new AdminProfile();
            bool isRegistered = false;
            char option;
            char continueChoice;

            Console.WriteLine("=== Welcome to the Admin Section ===");

            do
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("A - Register as Admin");
                Console.WriteLine("D - Display Admin Details");
                Console.Write("Enter your choice: ");
                option = Convert.ToChar(Console.ReadLine().ToUpper());

                switch (option)
                {
                    case 'A':
                        Console.WriteLine("--- Register Admin ---");
                        Console.Write("Enter Name: ");
                        admin.Name = Console.ReadLine();
                        Console.Write("Enter Username: ");
                        admin.Username = Console.ReadLine();
                        Console.Write("Enter Email: ");
                        admin.Email = Console.ReadLine();
                        Console.Write("Enter Phone Number: ");
                        admin.Phone = Console.ReadLine();

                        isRegistered = true;
                        Console.WriteLine(" Admin registered successfully.");
                        break;

                    case 'D':
                        switch (isRegistered)
                        {
                            case true:
                                Console.WriteLine("--- Admin Details ---");
                                Console.WriteLine("Name: " + admin.Name);
                                Console.WriteLine("Username: " + admin.Username);
                                Console.WriteLine("Email: " + admin.Email);
                                Console.WriteLine("Phone: " + admin.Phone);
                                break;

                            case false:
                                Console.WriteLine(" No admin has been registered yet.");
                                break;
                        }
                        break;

                    default:
                        Console.WriteLine("Invalid choice. Please enter 'A' or 'D'.");
                        break;
                }

                Console.Write("Do you want to continue? (Y/N): ");
                continueChoice = Convert.ToChar(Console.ReadLine().ToUpper());

            } while (continueChoice == 'Y');

            Console.WriteLine(" Thank you for using the Admin System. Goodbye!");
        }
    }
}
