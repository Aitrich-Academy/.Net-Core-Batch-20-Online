using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using ValidationActivity1Exception.VlidationException;

namespace ValidationActivity1Exception
{
    internal class User
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public User() { }
        public User(string id, string name, string email, string phone)
        {
            this.ID = id;
            this.Name = name;
            this.Email = email;
            this.Phone = phone;
        }

        public void Add()
        {
          ID  = GetID();
          Name =  GetName();
           Email = GetEmail();
           Phone = GetPhone();
        }
            public static string GetID()
            {
                string idRegex = @"^\d+$";
            string id = null ;
            try
                {
                    
                    Console.WriteLine("Please enter your ID :");
                    id = Console.ReadLine();
                    if (!Regex.IsMatch(id, idRegex))
                    {
                        throw new IDException("invalid");

                    }
               
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    GetID();
                }
             return id;

            }
        public static string GetName()
        {
            string nameRegex = @"^[a-zA-Z\s\-]+$";
            string name = null;
            try
            {
               
                Console.WriteLine("Please enter your name  :");
                name = Console.ReadLine();
                if (!Regex.IsMatch(name, nameRegex))
                {
                    throw new NameException("name formate is invalid ");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                GetName();
            }
            return name;
        }

        public static string GetEmail()
        {
            string emailRegex = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            string Email=null;
            try
            {
               
                Console.WriteLine("Please enter your Email :");
                Email = Console.ReadLine();
                if (!Regex.IsMatch(Email, emailRegex))
                {
                    throw new Exception("email is not valid");
                }



            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                GetEmail();
            }
            return Email;

        }
                public static string GetPhone()
                {
                    string PhoneRegex = @"^\+?[1-9][0-9]{7,14}$";
            string Phone = null;
            try
                    {
                       
                        Console.WriteLine("Enter Your Phone Number :");
                        Phone = Console.ReadLine();
                        if (!Regex.IsMatch(Phone, PhoneRegex))
                        {
                            throw new PhoneException("Invalid number");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        GetPhone();
                    }
            return Phone;
                }

           
        
        public void Display()
        {
            Console.WriteLine("ID : {0}", ID);
            Console.WriteLine(" Name: {0}", Name);
            Console.WriteLine("Email: {0}", Email);
            Console.WriteLine("Phone: {0}", Phone);
        }
        
    }

}
