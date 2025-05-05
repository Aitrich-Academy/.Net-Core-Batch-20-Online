using System.Text.RegularExpressions;
using Exception;

internal class Program
{


    private static void Main(string[] args)
    {

        string email = null;
        string input;

        while (email == null)
        {

            try
            {

                Console.WriteLine("Enter Email id : ");

                input = Console.ReadLine();
                email = ValidateEmail(input);



            }
            catch (EmailValidation e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }


        public static string ValidateEmail(string email){

        string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        if (!Regex.IsMatch(email, emailPattern))
            {
                throw new EmailValidation("Email is Not Valid .. try agin");
            }
            Console.WriteLine("Email is Valid");
        return email;


        }
        


    

       
    
}