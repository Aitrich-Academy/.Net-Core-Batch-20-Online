using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Schema;
using CompanyMember.Exceptions;
using CompanyMember.Interfaces;
using CompanyMember.Models;
using CompanyMember.Repository;

namespace CompanyMember.Manager
{
    internal class CompanyManager : IMenu
    {
        CompanyRepository companyRepository = new CompanyRepository();
        Lists list = new Lists();
        IMenu menu;
        public CompanyManager() { }

        public void DisplayMenu()
        {
            showCompanyMenu();
        }

        public void showCompanyMenu()
        {
            while (true)
            {
                Console.WriteLine("Choose an option");
                Console.WriteLine("1 - Register");
                Console.WriteLine("2 - List Companies");
                Console.WriteLine("3 - Job Provider Menu");
                Console.WriteLine("4 - Exit");

                string option = Console.ReadLine();
                bool exitprogram = false;
                
                while(!exitprogram)
                {
                    switch (option)
                    {
                        case "1":
                            Console.WriteLine("Register a Company");
                            RegisterCompany();
                            showCompanyMenu();
                            break;
                        case "2":

                            List<Company> companies = companyRepository.ListCompanies();

                            list.print(companies);
                            showCompanyMenu();
                            break;
                        case "3":
                            menu = new ProviderManager();
                            menu.DisplayMenu();
                            break;
                        case "4":
                            Console.WriteLine("Exiting.......");
                            exitprogram = true;
                            break;
                        default:
                            Console.WriteLine("Invalid Option");
                            break;


                    }
                }
            }
        }

        public void RegisterCompany()
        {
            try
            {
                Company company = new Company();

                Console.WriteLine("Please enter your Company Name:");
                company.Name = Console.ReadLine();
                company.Email = GetEmail();

                Console.WriteLine("Please enter your Company Website");

                company.Website = Console.ReadLine();


                company.Phone = GetPhoneNumber();

                Console.WriteLine("Enter about Company");
                company.About = Console.ReadLine();
                Console.WriteLine("Enter Company Vision");
                company.Vision = Console.ReadLine();
                Console.WriteLine("Enter Company Mission");
                company.Mission = Console.ReadLine();
                Console.WriteLine("Enter Company Location");
                company.Location = Console.ReadLine();
                Console.WriteLine("enter Company Address");
                company.Address = Console.ReadLine();

                bool result = companyRepository.Register(company);
                if (result == true)
                {
                    Console.WriteLine("----------Registration Successfull----------");
                    

                   
                }

            }
            catch (UserAlreadyExistException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex) 
            { Console.WriteLine(ex.Message); }
        }

        public string GetEmail()
        {
            try
            {
                string pattern = "^\\S+@\\S+\\.\\S+$";
                Console.WriteLine("Enter your Email Address : ");
                string email = Console.ReadLine();
                if (Regex.IsMatch(email, pattern))
                {
                    return email;
                }
                throw new InvalidFormatException("Invalid email ," + email);
            }
            catch (InvalidFormatException ex)
            {
                Console.WriteLine(ex.Message + "\n");
                Console.WriteLine("try again....");
                return GetEmail();
            }
            catch(Exception e)
            {
                Console.WriteLine (e.Message + "\n");
                Console.WriteLine("try again...");
                return GetEmail();

            }


        }

        public long GetPhoneNumber()
        {
            try
            {
                Console.WriteLine("Please enter your phone number:");
                long Phone = long.Parse(Console.ReadLine());
                return Phone;
            }
            catch (Exception e)
            {
                Console.WriteLine("Enter valid phone number");
                return GetPhoneNumber();
            }
        }

    }
}
        
    

