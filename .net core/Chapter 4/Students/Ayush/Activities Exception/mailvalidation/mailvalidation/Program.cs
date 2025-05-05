using System.Text.RegularExpressions;

namespace mailvalidation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            do
            {
                string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

                try
                {
                    Console.WriteLine("Enter your Email: ");
                    string email = Console.ReadLine();

                    if (!Regex.IsMatch(email, pattern))
                    {
                        throw new EmailException();   
                    }
                    else
                    {
                        Console.WriteLine("email is valid");
                        break;
                    }
                }
                catch (EmailException e)
                {
                    Console.WriteLine(e.Message);
                }

                finally
                {
                    Console.WriteLine("goodbye\n");
                }
            } while (true);
                Console.WriteLine("Exiting");
            
        
        }   

    }

}

