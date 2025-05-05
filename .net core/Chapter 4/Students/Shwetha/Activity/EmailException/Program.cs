using System;
using System.Text.RegularExpressions;
namespace EmailException
{
    internal class Program
    {
        private static readonly Regex EmailPattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        private static void EvaluateText(string email)
        {
            if (!EmailPattern.IsMatch(email))
            {
                throw new E_Exception();
            }
        }
        public static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the email ID:");
                string email = Console.ReadLine();

                EvaluateText(email);
                Console.WriteLine("Email is valid.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }



    }
}
