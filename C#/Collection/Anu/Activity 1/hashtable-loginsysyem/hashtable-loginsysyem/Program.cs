using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hashtable_loginsysyem
{
    internal class Program
    {
        static Hashtable users = new Hashtable();
        static void Main(string[] args)
        {
            users.Add("anu", "password123");
            users.Add("ami", "password111");
            users.Add("kunju", "password222");

            Console.WriteLine("=== Simple Login System ===");

            while (true)
            {
                Console.Write("\nEnter username: ");
                string username = Console.ReadLine();

                Console.Write("Enter password: ");
                string password = Console.ReadLine();

                if (ValidateLogin(username, password))
                {
                    Console.WriteLine("\n✅ Login successful! Welcome, " + username + "!");
                    break;
                }
                else
                {
                    Console.WriteLine("\n❌ Invalid username or password.");
                    Console.Write("Try again? (y/n): ");
                    string retry = Console.ReadLine();
                    if (retry.ToLower() != "y")
                    {
                        Console.WriteLine("Exiting program.");
                        break;
                    }
                }
            }
        }

        // Validate user credentials
        static bool ValidateLogin(string username, string password)
        {
            if (users.ContainsKey(username))
            {
                return users[username].ToString() == password;
            }
            return false;
        }
    }
    
}
