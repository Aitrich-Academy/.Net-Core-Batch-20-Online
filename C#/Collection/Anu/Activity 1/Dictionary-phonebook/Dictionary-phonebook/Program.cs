using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary_phonebook
{
    internal class Program
    {
        static Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        static void Main(string[] args)
        {
            bool running = true;

            while (running)
            {
                Console.WriteLine("\nPhone Book Application");
                Console.WriteLine("1. Add New Contact");
                Console.WriteLine("2. Search Contact by Name");
                Console.WriteLine("3. Display All Contacts");
                Console.WriteLine("4. Exit");
                Console.Write("Choose an option (1-4): ");

                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddContact();
                        break;
                    case "2":
                        SearchContact();
                        break;
                    case "3":
                        DisplayAllContacts();
                        break;
                    case "4":
                        running = false;
                        Console.WriteLine("Exiting application.");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            }
        }

        static void AddContact()
        {
            Console.Write("Enter name: ");
            string name = Console.ReadLine();

            if (phoneBook.ContainsKey(name))
            {
                Console.WriteLine("Contact already exists.");
                return;
            }

            Console.Write("Enter phone number: ");
            string phoneNumber = Console.ReadLine();

            phoneBook[name] = phoneNumber;
            Console.WriteLine("Contact added successfully.");
        }

        static void SearchContact()
        {
            Console.Write("Enter name to search: ");
            string name = Console.ReadLine();

            if (phoneBook.TryGetValue(name, out string number))
            {
                Console.WriteLine($"Name: {name}, Phone Number: {number}");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        static void DisplayAllContacts()
        {
            if (phoneBook.Count == 0)
            {
                Console.WriteLine("No contacts to display.");
                return;
            }

            Console.WriteLine("\nAll Contacts:");
            foreach (var contact in phoneBook)
            {
                Console.WriteLine($"Name: {contact.Key}, Phone Number: {contact.Value}");
            }
        }
    }
}
