using phonecontact_using_dictionry;

internal class Program
{
    private static void Main(string[] args)
    {

        ContactZ c = new ContactZ();
        while (true)
        {
            Console.WriteLine("\nContact Book Menu:");
            Console.WriteLine("1. Add New Contact");
            Console.WriteLine("2. Search Contact by Name");
            Console.WriteLine("3. Display All Contacts");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice (1-4): ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    c.contactss();
                    break;
                case "2":
                    c.SearchContact();
                    break;
                case "3":
                   c. DisplayContacts();
                    break;
                case "4":
                    Console.WriteLine("Exiting Contact Book. Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                    break;
            }
        }
    }
}