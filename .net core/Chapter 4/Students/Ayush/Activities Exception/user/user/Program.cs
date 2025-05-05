using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using System.Xml.Linq;

namespace user
{
    public class Program
    {
        public static void Main(string[] args)
        {
            User[] user = new User[5];
            
            int usercount = 0;
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            bool exitprogram = false;






            while (!exitprogram)
            {
                Console.WriteLine("\n1. Add User");
                Console.WriteLine("2.Exit");
                Console.WriteLine("Enter you choice: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        {
                            string userid;
                            while (true) {
                                try
                                {
                                    


                                    Console.WriteLine("Enter Userid: ");
                                    userid = Console.ReadLine();
                                    if (string.IsNullOrEmpty(userid) || !Regex.IsMatch(userid, @"^\d+$"))
                                    {
                                        throw new UserException("userid cannot be empty!! or must be numbers!!!");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                catch (UserException e)
                                {
                                    Console.WriteLine(e.Message);
                                }

                            } 



                                string name;
                            while (true)
                            {
                                try
                                {

                                    Console.WriteLine("Enter Name: ");
                                    name = Console.ReadLine();
                                    if (string.IsNullOrEmpty(name))
                                    {
                                        throw new UserException("Name cannot be empty!!");

                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                catch (UserException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }

                            string email;
                            while (true) 
                            {
                                try
                                {
                                    

                                    Console.WriteLine("Enter your Email: ");
                                    email = Console.ReadLine();
                                    if (!Regex.IsMatch(email, pattern))
                                    {

                                      
                                        throw new UserException("Invalid email!!");

                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                catch (UserException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }


                                string phone;
                            while (true)
                            {
                                try
                                {
                                    Console.WriteLine("Enter your Phone: ");
                                    phone = Console.ReadLine();
                                    if (phone.Length != 10)

                                    {

                                       
                                        throw new UserException("phone number must contain 10 digits!!!");
                                    }
                                    else
                                    {
                                        break;
                                    }
                                }
                                catch (UserException e)
                                {
                                    Console.WriteLine(e.Message);
                                }
                            }

                                user[usercount] = new User(userid, name, email, phone);
                                usercount++;
                                Console.WriteLine("user added successfully");

                            break;  
                           
                        }
                    case "2":
                        {
                            Console.WriteLine("Exiting\n");
                            return;
                        }
                    default:
                        Console.WriteLine("invalid choice!!\n");
                        break;
                }
            }
           
    }

        
    }
}
