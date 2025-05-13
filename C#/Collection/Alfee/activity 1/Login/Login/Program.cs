using System;
using System.Collections;

class Program
{
    static void Main()
    {
        // Create a Hashtable to store usernames and passwords
        Hashtable loginSystem = new Hashtable();

        // Adding some predefined usernames and passwords to the Hashtable (simulating a database)
        loginSystem.Add("user1", "password123");
        loginSystem.Add("admin", "admin@123");
        loginSystem.Add("guest", "guestpass");

        bool exit = false;

        while (!exit)
        {
            // Display Menu
            Console.WriteLine("\nLogin System");
            Console.WriteLine("1. Login");
            Console.WriteLine("2. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Login Process
                    Console.Write("Enter your username: ");
                    string username = Console.ReadLine();

                    Console.Write("Enter your password: ");
                    string password = Console.ReadLine();

                    // Validate login credentials
                    if (loginSystem.ContainsKey(username))
                    {
                        if ((string)loginSystem[username] == password)
                        {
                            Console.WriteLine("Login successful!");
                        }
                        else
                        {
                            Console.WriteLine("Incorrect password. Try again.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Username not found. Please check and try again.");
                    }
                    break;

                case "2":
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