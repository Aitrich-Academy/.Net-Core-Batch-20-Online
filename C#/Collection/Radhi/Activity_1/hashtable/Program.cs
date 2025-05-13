using static System.Formats.Asn1.AsnWriter;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections;

internal class Program
{
    private static void Main(string[] args)
    {
        //Implement a simple login system.
        //Store usernames and passwords in a Hashtable(assume plaintext for now).
        //Allow users to log in by entering their username and password, and validate them using the hashtable.
        Hashtable users = new Hashtable();

        // Add some sample users (username -> password)
        users.Add("radhi", "234");
        users["bob"] = "securepass";
        users["charlie"] = "mypassword";

        Console.Write("Enter username: ");
        string username = Console.ReadLine();

        Console.Write("Enter password: ");
        string password = Console.ReadLine();

        // Validate login
        if (users.ContainsKey(username))
        {
            if (users[username].ToString() == password)
            {
                Console.WriteLine("Login successful! Welcome, " + username + ".");
            }
            else
            {
                Console.WriteLine("Incorrect password.");
            }
        }
        else
        {
            Console.WriteLine("Username not found.");
        }
    }
}
   