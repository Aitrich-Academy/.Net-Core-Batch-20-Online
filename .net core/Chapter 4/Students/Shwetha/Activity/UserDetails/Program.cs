using System;
using System.Text.RegularExpressions;
namespace UserDetails
{
    internal class Program
    {
        private static readonly Regex EmailPattern = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
        private static readonly Regex PhonePattern = new Regex(@"^\+?[1-9][0-9]{7,14}$");
        private static readonly Regex NamePattern = new Regex(@"^[a-zA-Z\s\-]+$");
        private static readonly Regex IDPattern = new Regex(@"^\d+$");
        private static void EvaluateText(string user_email)
        {
            if (!EmailPattern.IsMatch(user_email))
            {
                throw new EmailException();
            }
        }
        private static void EvaluateNumber(string user_number)
        {
            if (!PhonePattern.IsMatch(user_number))
            {
                throw new PhoneException();
            }
        }
        private static void EvaluateName(string user_name)
        {
            if(!NamePattern.IsMatch(user_name))
            {
                throw new NameException();
            }
              
        }
     
        private static void EvaluateId(string user_id)
        {
            if (!IDPattern.IsMatch(user_id))
            {
                throw new IdException();
            }
        }

        public static void Main(string[] args)
        {
            User[] user = new User[10];
            string user_number;
            string user_email;
            int user_id;
            string user_name;
            int count = 0;
            string choice;
            do
            {
                try
                {
                    while(true)
                    {
                       
                        try
                        {
                            Console.WriteLine("Enter your name");
                            user_name = Console.ReadLine();
                            EvaluateName(user_name);
                            break;
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    
                    
              
                    while(true)
                    {
                        
                        try
                        {
                            Console.WriteLine("Enter your ID");
                            string id = Console.ReadLine();
                            EvaluateId(id);
                            user_id = int.Parse(id);
                            break;
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                   
                 
                  while(true)
                    {
                       
                        try
                        {
                            Console.WriteLine("Enter Email Id");
                            user_email = Console.ReadLine();
                            EvaluateText(user_email);
                            break;
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                    
                  
                    
                    while(true)
                    {
                      
                        try
                        {
                            Console.WriteLine("Enter phone number");
                            user_number = Console.ReadLine();
                            EvaluateNumber(user_number);
                            break;
                        }
                        catch(Exception ex)
                        {
                            Console.WriteLine(ex.Message);
                        }
                    }
                   
                   
                    User newUsers = new User
                    {
                        Name = user_name,
                        ID = user_id,
                        Email = user_email,
                        PhoneNumber = user_number
                    };

                    user[count] = newUsers;
                    count++;
                    Console.WriteLine("Succsfully stored.....");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurd",ex.Message);
                }
                Console.WriteLine("Do you want to add another user? (y/n):");
                choice = Console.ReadLine();
            } while (choice == "Y" || choice == "y");
            
           
           
                Console.WriteLine("Stored Users:");
            if (user != null)
            {
                foreach (var item in user)
                {
                    if (item != null)
                    {
                        Console.WriteLine("Id : {0}", item.ID);
                        Console.WriteLine("Name : {0}", item.Name);
                        Console.WriteLine("Email : {0}", item.Email);
                        Console.WriteLine("Phone : {0}", item.PhoneNumber);

                        Console.WriteLine("*********************************");
                    }
                }
            }
        }
    }
}