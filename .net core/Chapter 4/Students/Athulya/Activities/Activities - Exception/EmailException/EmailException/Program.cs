using EmailException.Exceptions;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace EmailException
{
    internal class Program
    {
        public static void Main(string[] args)
        {
           Add();
        }

       public static void Add()
        {

            string emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";


            try
            {

                Console.WriteLine("Enter your email id :");
                string Email = Console.ReadLine();


                if (!Regex.IsMatch(Email, emailRegex))
                {
                    throw new EmailcheckException("Email is not valid");
                   


                }

            }

            catch (EmailcheckException e)
            {
                Console.WriteLine("Email is not valid");
                Add();

            }

            finally
            {
                Console.WriteLine("exit");
            }
        }
    }
}



