using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonecontact_using_dictionry
{
    public class ContactZ
    {
        static Dictionary<string, string> contacts = new Dictionary<string, string>();
        public void contactss()
        {
            Console.Write("Enter contact name: ");
            string name = Console.ReadLine();

            if (contacts.ContainsKey(name))
            {
                Console.WriteLine("Contact already exists.");
            }
            else
            {
                Console.Write("Enter phone number: ");
                string phone = Console.ReadLine();
                contacts[name] = phone;
                Console.WriteLine($"Contact {name} added successfully.");
            }
        }

        public void SearchContact()
        {
            Console.Write("Enter name to search: ");
            string name = Console.ReadLine();

            if (contacts.ContainsKey(name))
            {
                Console.WriteLine($"{name}'s phone number is {contacts[name]}");
            }
            else
            {
                Console.WriteLine("Contact not found.");
            }
        }

        public void DisplayContacts()
        {
            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts to display.");
            }
            else
            {
                Console.WriteLine("\nAll Contacts:");
                foreach (var contact in contacts)
                {
                    Console.WriteLine($"{contact.Key}: {contact.Value}");
                }
            }

        }
    }
}
