
using ExcerciseCity;
using System.Collections.Generic;
using System.Linq;
using System.Net;
internal class Program
{
    private static void Main(string[] args)
    {

        //    Country india = new Country { CountryID = 1, CountryName = "India" };
        //    Country usa = new Country { CountryID = 2, CountryName = "USA" };
        //    Country uk = new Country { CountryID = 3, CountryName = "UK" };

        //    City mumbai = new City { CityId = 1, CityName = "Mumbai" };
        //    City kochi = new City { CityId = 2, CityName = "Kochi"};
        //    City delhi = new City { CityId = 3, CityName = "Delhi"};
        //    City Pheladeiphia = new City { CityId = 4, CityName = "Phyladelphia" };
        //    City newyork = new City { CityId = 5, CityName = "NewYork" };
        //    City london = new City { CityId = 6, CityName = "London" };
        List<Country> people = new List<Country>()
        {
         new Country{FirstName ="Asha",LastName = "Raj",DateofBirth = new DateTime(2018,12,12),RoomNumber =  "102AD", Building = "Galaxy Appartments", Street = "Broadway street",Phone =  9876543210, Email = "asha@gmail.com", CityId = 112,CityName = "Kochi",CountryID =  202,CountryName =  "India",},
     new Country{FirstName ="Swapna",LastName = "Kapoor",DateofBirth = new DateTime(2019,09,09),RoomNumber =  "104ED", Building = "Blossom ApRTMENTS", Street = "Jewel street",Phone =  1234567890, Email = "swapna@gmail.com", CityId = 110,CityName = "Mumbai",CountryID =  221,CountryName =  "India",},
     new Country{FirstName ="Abhishek",LastName = "varun",DateofBirth = new DateTime(2020,02,20),RoomNumber =  "103AM", Building = "Angel Appartments", Street = "Panicker street",Phone =  9876547460, Email = "abhishek@gmail.com", CityId = 121,CityName = "Newyork",CountryID =  222,CountryName =  "USA",},
        };
        string choice;
        do
        {
            Console.WriteLine("Welcome to Application");
            Console.WriteLine("1. Add Person");
            Console.WriteLine("2. List Persons by city");
            Console.WriteLine("3. List Persons by Country");
            Console.WriteLine("4. List Address by country,city");
            Console.WriteLine("5. List Address by country, city, name");
            Console.WriteLine("6. List Address by country, city , age descending");
            Console.WriteLine("7. Persons older than 25");
            Console.WriteLine("8. Persons working in a city");
            Console.WriteLine("9. Person working below 20 years");
            Console.WriteLine("10. List country wise Addresses");
            Console.WriteLine("11. List By Age");
            Console.WriteLine("12. Exit");
            Console.Write("Enter choice: ");
            choice = Console.ReadLine();
           

            switch (choice)
            {

                case "1":
                    Console.WriteLine("Adding a new person to the address book:");

                    Console.Write("Enter First Name: ");
                    string firstName = Console.ReadLine();

                    Console.Write("Enter Last Name: ");
                    string lastName = Console.ReadLine();

                    Console.Write("Enter Date of Birth (yyyy-mm-dd): ");
                    DateTime dateOfBirth;
                    while (!DateTime.TryParse(Console.ReadLine(), out dateOfBirth))
                    {
                        Console.Write("Invalid date format. Please enter again: ");
                    }

                    Console.Write("Enter Home Address - City Name: ");
                    Console.Write("Room no:");
                    string homeRoomNo = Console.ReadLine();
                    Console.Write("Building no :");
                    string homebuilding = Console.ReadLine();
                    Console.Write("Enter Street : ");
                    string homestreet = Console.ReadLine();
                    Console.Write("Enter Phone Number : ");
                    long homePhone = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Enter Email : ");
                    string email = Console.ReadLine();
                    Console.Write("Enter City Id : ");
                    int homecityid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter City : ");
                    string homecity = Console.ReadLine();
                    Console.Write("Enter country id : ");
                    int homecountryid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Country Name : ");
                    string homecountry = Console.ReadLine();
                    Console.WriteLine();

                    Console.WriteLine("Enter Work Address");
                    Console.Write("Room no:");
                    string WorkRoomNo = Console.ReadLine();
                    Console.Write("Building no :");
                    string Workbuilding = Console.ReadLine();
                    Console.Write("Enter Street : ");
                    string Workstreet = Console.ReadLine();
                    Console.Write("Enter Phone Number : ");
                    long WorkPhone = Convert.ToInt64(Console.ReadLine());
                    Console.Write("Enter Email : ");
                    string Workemail = Console.ReadLine();
                    Console.Write("Enter City Id : ");
                    int Workcityid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter City : ");
                    string Workcity = Console.ReadLine();
                    Console.Write("Enter country id : ");
                    int Workcountryid = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter Country Name : ");
                    string Workcountry = Console.ReadLine();

                    Country person = new Country(homecountryid, homecountry, homecityid, homecity, homeRoomNo, homebuilding, homestreet, homePhone, email, firstName, lastName, dateOfBirth,
                        new Address(homeRoomNo, homebuilding, homestreet, homePhone, email),
                        new Address(homeRoomNo, homebuilding, homestreet, homePhone, email));

                    people.Add(person);
                    Console.WriteLine("Person added successfully!");
                    break;
                    case "2":
                       {
                       var cityGroups = people.GroupBy(x => x.CityName);
        {
            foreach (var group in cityGroups)
            {
                Console.WriteLine($"City is {group.Key}");
                foreach (var peoples in group)
                {
                    Console.WriteLine($"Full Name  :- {peoples.FirstName} {peoples.LastName}");
                }
            }

        }
    }
                    break;
                case "3":

                    var groupCountry = people.GroupBy(e => e.CountryName)
                        .OrderBy(g => g.Key);
                    {
                        foreach (var countries in groupCountry)
                        {
                            Console.WriteLine($"Country is {countries.Key}");
                            foreach (var peoples in countries)
                            {
                                peoples.dispalydetails();
                            }
                        }
                    }
                    break;
                case "4":
                    var countrycitygroup = people.GroupBy(x => x.CountryName)
                                          .OrderBy(c => c.Key);
                    foreach (var countrycity in countrycitygroup)
                    {
                        Console.WriteLine("Details of country and city", countrycity.Key);
                        Console.WriteLine();
                        foreach (var peopl in countrycity.OrderBy(g => g.CityName))
                        {

                            peopl.dispalydetails();

                        }
                    }
                    break;
                case "5":
                    var councitname = people.GroupBy(x => x.CountryName)
                                   .OrderBy(c => c.Key);

                    foreach (var countrycityname in councitname)
                    {
                        Console.WriteLine("Country : ", countrycityname.Key);
                        foreach (var ccn in countrycityname.OrderBy(x => x.CityName).ThenBy(c => c.FirstName))
                        {
                            ccn.dispalydetails();
                        }
                    }
                    break;
                case "6":
                    var councityagegrouped = people.GroupBy(x => x.CountryName)
                .OrderBy(c => c.Key);

                    foreach (var councitagegroup in councityagegrouped)
                    {
                        Console.WriteLine("Details of country,city age ", councitagegroup.Key);
                        foreach (var agedec in councitagegroup.OrderBy(c => c.CityName).ThenByDescending(c => DateTime.Now.Year - c.DateofBirth.Year))
                        {
                            agedec.dispalydetails();
                        }
                    }
                    break;
                case "7":
                    var result = people.Where(p => (DateTime.Now.Year - p.DateofBirth.Year) > 25).ToList();
                    {
                        Console.WriteLine("Person older than 25");
                        foreach (var pers in result)
                        {
                            pers.dispalydetails();
                        }
                    }
                    break;
                case "8":
                    Console.WriteLine("Enter city name");
                    string city = Console.ReadLine();

                    var resultcity = people.Where(p => p.CityName.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
                    {
                        Console.WriteLine($"All persons working under the {city}");
                        foreach (var peopl in resultcity)
                        {
                            peopl.dispalydetails();
                        }
                    }
                    break;
                case "9":
                    Console.WriteLine("Enter city name");
                    var namecity = Console.ReadLine();

                    var resultage = people.Where(p => (DateTime.Now.Year - p.DateofBirth.Year) < 20 && p.CityName.Equals(namecity, StringComparison.OrdinalIgnoreCase)).ToList();
                    {
                        Console.WriteLine($"Person working in {namecity} under age 20");
                        foreach (var peop in resultage)
                        {
                            peop.dispalydetails();
                        }
                    }
                    break;
                case "10":
                    Dictionary<string, List<Person>> countrywiseAddress = new Dictionary<string, List<Person>>();
                    {
                        foreach (var country in countrywiseAddress)
                        {
                            Console.WriteLine("Country Name :-", country.Key);

                            foreach (var persons in country.Value)
                            {
                                Console.WriteLine($"Name : {persons.FirstName} {persons.LastName} ");
                            }

                        }

                    }
                    break;
                case "11":
                    var results = people.OrderBy(p => DateTime.Now.Year - p.DateofBirth.Year).ToList();
                    Console.WriteLine($"Persons listing with respect to Age");
                    foreach (var resultlist in results)
                    {
                        Console.WriteLine($"Name : {resultlist.FirstName}{resultlist.LastName}");
                        Console.WriteLine($"Age : {(DateTime.Now.Year - resultlist.DateofBirth.Year)}");
                        Console.WriteLine($"City : {resultlist.CityName}");
                        Console.WriteLine($"Country : {resultlist.CountryName}");
                    }
            
            break;
                case "12":
                    Console.WriteLine("Exiting............");
                    return;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
        
     } while(choice != "12");
    }
}






                    
    
    


