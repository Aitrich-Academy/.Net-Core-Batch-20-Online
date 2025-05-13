using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Dictionary to store name as key and phone number as value
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        bool exit = false;

        while (!exit)
        {
            // Display Menu
            Console.WriteLine("\nPhone Book Application");
            Console.WriteLine("1. Add New Contact");
            Console.WriteLine("2. Search for a Contact by Name");
            Console.WriteLine("3. Display All Contacts");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Add New Contact
                    Console.Write("Enter the name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter the phone number: ");
                    string phoneNumber = Console.ReadLine();

                    // Add the contact to the dictionary
                    if (!phoneBook.ContainsKey(name))
                    {
                        phoneBook.Add(name, phoneNumber);
                        Console.WriteLine("Contact added successfully.");
                    }
                    else
                    {
                        Console.WriteLine("This contact already exists.");
                    }
                    break;

                case "2":
                    // Search for a Contact by Name
                    Console.Write("Enter the name to search: ");
                    string searchName = Console.ReadLine();

                    if (phoneBook.ContainsKey(searchName))
                    {
                        Console.WriteLine($"Contact Found: {searchName} - {phoneBook[searchName]}");
                    }
                    else
                    {
                        Console.WriteLine("Contact not found.");
                    }
                    break;

                case "3":
                    // Display All Contacts
                    Console.WriteLine("\nPhone Book Contacts:");
                    foreach (var contact in phoneBook)
                    {
                        Console.WriteLine($"{contact.Key} - {contact.Value}");
                    }
                    break;

                case "4":
                    // Exit
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}