using System.Net.Http.Headers;
using System.Reflection.Metadata.Ecma335;
using System.Xml.Serialization;
using UserValidation;

internal class Program
{

    public static void Main(string[] args)
    {
        uservalidation uservalidation = new uservalidation();
        string choice = null;

        while (choice != "2")
        {

            Console.WriteLine("---------Choose an option---------");
            Console.WriteLine("1 - Add User");
            Console.WriteLine("2 - Exit");

            choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    uservalidation.AddUser();
                    break;
                case "2":
                    Console.WriteLine("Exiting........");
                    break;
                default:
                    Console.WriteLine("Invalid input");
                    break;

            }
        }
        
        


       
       
    }

    
}