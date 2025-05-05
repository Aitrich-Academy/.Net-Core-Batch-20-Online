using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;
using UserValidation.Exceptions;


namespace UserValidation
{
    internal class uservalidation
    {

        User[] users = new User[20];
        int usercount = 0;

        public void AddUser() {
           
           


            int id = ValidateId();
            string name = ValidateName();
            string email = ValidateEmail();
            string phone = ValidatePhone();

            users[usercount] = new User(id, name, email, phone);

            usercount++;
            Console.WriteLine("User Added Successfully\n");

            Console.WriteLine("------------Users Details-------------\n");

            foreach (User user in users)
            {
                if(user != null)
                {
                    user.DisplayInfo();
                }
                
            }
        }
        public int ValidateId()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter User Id : ");
                    string idInput = Console.ReadLine();

                    if (int.TryParse(idInput, out int id))
                    {

                        return id;
                    }
                    else
                    {
                        throw new InvalidIdException("Invalid Id. Please enter an Integer");
                    }
                }
                catch(InvalidIdException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }

        public string ValidateName()
        {
            while(true)

            {
                try
                {
                    Console.WriteLine("Enter Name : ");
                    string name = Console.ReadLine();
                    for (int i = 0; i < name.Length; i++)
                    {
                        if (Char.IsDigit(name[i]))
                        {

                            throw new InvalidNameException("Name cannot contain numbers. Enter valid Name");
                        }
                        
                    }
                    return name;
                }
                catch (InvalidNameException e)
                {
                    Console.WriteLine(e.Message);
                }


            }
        }

        public string ValidateEmail()
        {
            while(true)
            {
                try
                {

                    Console.WriteLine("Enter Email id : ");
                    string email = Console.ReadLine();
                    string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

                    if (!Regex.IsMatch(email, emailPattern))
                    {
                        throw new InvalidEmailException("Email is Not Valid .. try agin");
                    }

                    return email;
                }
                catch (InvalidEmailException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        public string ValidatePhone()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter phone number : ");
                    string phone = Console.ReadLine();

                    if (!Regex.IsMatch(phone, @"^\d{10}$"))
                    {
                        throw new InvalidPhoneException("Phone number should be exactly 10 digits ..try again");
                    }
                    return phone;
                }
                catch (InvalidPhoneException e)
                {
                    Console.WriteLine(e.Message);
                }

            }
        }
    }
}
