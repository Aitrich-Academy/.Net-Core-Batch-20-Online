using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using emailexception.Exception;

public class Program
{
    private static void Main(string[] args)
    {
        
        Console.WriteLine("Welcome");
        string email = string.Empty;
        bool isValid = false;


        while (!isValid)
        {

            Console.WriteLine("Enter an Email ID");
            email = Console.ReadLine();
            try
            {

                ValidateEmailID(email);
                isValid = true;
                Console.WriteLine("Valid Email format");
            }


            catch (ValidateEmail e)
            {
                Console.WriteLine("Validation error");
            }
            
        }
    
    }
        public static void ValidateEmailID(string email)
    {
        string pattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        if (!Regex.IsMatch(email, pattern))
        {
            throw new ValidateEmail($"The email is {email} not in valid format");
           
        }
       

    }
   



}
