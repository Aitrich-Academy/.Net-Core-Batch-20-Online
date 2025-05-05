using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
namespace AddressBook
{
    internal class Program
    {
       
        public static void  Main (string[] args)
        {

            string ch, op;
            List<Country> personDetails = new List<Country>();
            Dictionary<Country, List<Person>> MyDicnry = new Dictionary<Country, List<Person>>();
            //var q = personDetails.OrderBy(e => e.Country_Name).ToList();
            do
            {
                try
                {
                    Console.WriteLine("Address Book");
                    Console.WriteLine("::::::::::::::::::::::::::::::");
                    Console.WriteLine("1. Add Person Details");
                    Console.WriteLine("2. List by City");
                    Console.WriteLine("3. List by Country");
                    Console.WriteLine("4. List Older than 25");
                    Console.WriteLine("5. List by City and Age");
                    Console.WriteLine("6. Create Country Grouped Address Book");
                    Console.WriteLine("7. Display");
                    Console.WriteLine("8. Country - City - Firstname");
                    Console.WriteLine("9. Country - City - Age(Descending)");
                    Console.WriteLine("10. City - Name");
                    Console.WriteLine("Choose an option given above.....: ");
                    op = Console.ReadLine();
                    switch (op)
                    {
                        case "1":
                            {
                                Country personObj = new Country();
                                Console.WriteLine("Enter your first name :");
                                personObj.FirstName = Console.ReadLine();
                                Console.WriteLine("Enter your last name :");
                                personObj.LastName = Console.ReadLine();
                                Console.WriteLine("Enter your Age :");
                                personObj.Age = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine("Enter your City :");
                                personObj.City_Name = Console.ReadLine();
                                Console.WriteLine("Enter your Country :");
                                personObj.Country_Name= Console.ReadLine();
                                Console.WriteLine("Enter your Home Place :");
                                personObj.HomeAddress = Console.ReadLine();
                                Console.WriteLine("Enter your Work Placfe :");
                                personObj.WorkAddress = Console.ReadLine();
                                personDetails.Add(personObj);

                                break;
                            }
                        case "2":
                            {
                                if (personDetails != null)
                                {
                                    var city_Groups = personDetails.GroupBy(p => p.City);
                                    Console.WriteLine("Total no.of City : {0}" , city_Groups.Count());
                                    foreach (var group in city_Groups)
                                    {
                                        Console.WriteLine("City Name  : {0}", group.Key);
                                        foreach (var person in group)
                                        {
                                            Console.WriteLine("First Name  : {0} ",person.FirstName);
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("List is Empty");
                                }

                                break;
                            }
                        case "3":
                            {
                                if (personDetails != null)
                                {
                                    var country = personDetails.GroupBy(p => p.Country_Name);
                                    Console.WriteLine("Total no.of Country : {0}", country.Count());
                                    foreach (var c in country)
                                    {
                                        Console.WriteLine("Country ......{0}", c.Key);
                                        foreach (var person in c)
                                        {
                                            Console.WriteLine(person.FirstName);
                                        }
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("List is Empty");
                                }
                                break;
                            }
                        case "4":
                            {
                                var result = personDetails.Where(p => p.Age > 25);
                                foreach (var person in result)
                                {
                                    Console.WriteLine(person);
                                }
                                break;
                            }
                        case "5":
                            {
                                Console.WriteLine("Enter the City name");
                                string c = Console.ReadLine();
                                Console.WriteLine("Enter the age");
                                int a = Convert.ToInt32(Console.ReadLine());
                                Show_CityAndAge(c, a);
                                break;
                            }
                        case "6":
                            {
                                CountryGroupedAddressBook();
                                break;
                            }
                        case "7":
                            {
                                Console.WriteLine("::::::::::::Address book::::::::::");
                                foreach(var item in personDetails)
                                {
                                    Console.WriteLine("Name : {0}", item.FirstName);
                                    Console.WriteLine("Age : {0}", item.Age);
                                    Console.WriteLine("City : {0}", item.City_Name);
                                    Console.WriteLine("Contry : {0}", item.Country_Name);
                                    Console.WriteLine("**********************************");
                                }
                                break;
                            }
                        case "8":
                            {
                                var cont_city_first = personDetails.GroupBy(c => c.Country_Name);
                                foreach (var cont in cont_city_first)
                                {
                                    Console.WriteLine(cont.Key);
                                    var q = cont.OrderBy(e => e.City_Name).ThenBy(e => e.FirstName);
                                    foreach (var item in q)
                                    {
                                        Console.WriteLine("Name : {0}", item.FirstName);
                                    }
                                }
                            
                                   
                                break;
                            }
                        case "9":
                            {
                                var cont_city_age = personDetails.GroupBy(c => c.Country_Name);
                                foreach(var  cont in cont_city_age)
                                {
                                    Console.WriteLine(cont.Key);
                                    var age_desc = cont.OrderBy(a => a.City_Name).ThenByDescending(a => a.Age);
                                    {
                                        foreach(var item in age_desc)
                                        {
                                            Console.WriteLine("Name : {0}  Age : {0}", item.FirstName, item.Age);
                                        }
                                    }
                                }
                                break;
                            }
                        case "10":
                            {
                                var city_age = personDetails.Where(e => e.Age >20).
                                    GroupBy(e => e.City_Name);
                                foreach(var c in  city_age)
                                {
                                    Console.WriteLine(c.Key);
                                    foreach( var item in city_age)
                                    {
                                        Console.WriteLine( item);
                                    }
                                }
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid Choice.........!!!!");
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Do you wish to continue...... (y/n).?");
                ch = Console.ReadLine();
            } while (ch == "Y" || ch == "y");

            void Show_CityAndAge(string city, int maxAge)
            {

                var result = personDetails.Where(p => p.City == city && p.Age <= maxAge);
                foreach (var person in result)
                {
                    Console.WriteLine("Name : {0} City : {1} ", person , city);
                }
            }
            void CountryGroupedAddressBook()
            {
                var countryGroups = personDetails.GroupBy(p => p.Country_Name);
                    

                foreach (var country in countryGroups)
                {
                    Console.WriteLine("Country : {0) ", country);
                    foreach (var person in country) 
                    {
                        Console.WriteLine("Name  : {0}" ,person.FirstName);
                    }
                }
            }
        }
    }

}