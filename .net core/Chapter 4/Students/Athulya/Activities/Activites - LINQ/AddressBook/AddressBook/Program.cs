using System;

namespace AddressBook
{
    internal class Program
    {

        public static List<Country> person = new List<Country>();
        public static int count = 0;
        private static void Main(string[] args)
        {
            bool program = false;
            string choose;
            do
            {
                Console.WriteLine("..................Address Book .......................");
                Console.WriteLine("1 . Add Address");
                Console.WriteLine("2 . Display Address");
                Console.WriteLine("3 .List out from Country");
                Console.WriteLine("4 .List by cityName");

                Console.WriteLine("5 .List All people older than 25 years");
                Console.WriteLine("6 .List all people working in given city name");
                Console.WriteLine("7 .Address group by country");
                Console.WriteLine("8 .Exit");
                Console.WriteLine("Choose options ");
                choose = Console.ReadLine();


                switch (choose)
                {
                    case "1":
                        addperson();
                        break;


                    case "2":
                        Display();
                        break;

                    case "3":
                        var query = person.GroupBy(e => e.CountryName);

                        Console.WriteLine("*****-------*****");
                        foreach (var q1 in query)
                        {
                            Console.WriteLine($"\nCountry:{q1.Key}");
                            foreach (var q2 in q1.OrderBy(e => e.CityName).ThenBy(e => e.FirstName).ThenByDescending(e => e.Age))
                            {

                                Console.WriteLine($"Name: {q2.FirstName + q2.LastName} City: {q2.CityName} Age:{q2.Age}Address: {q2.HomeAddress}");
                            }
                        }
                        break;

                    case "4":
                        var query1 = person.GroupBy(e => e.CityName);
                        Console.WriteLine("*****-------*****");
                        foreach (var q1 in query1)
                        {
                            Console.WriteLine($"\nCity :{q1.Key}");
                            foreach (var q2 in q1)
                            {

                                Console.WriteLine($"Name: {q2.FirstName + q2.LastName}  Address: {q2.HomeAddress} Country:{q2.CountryName}");
                            }
                        }
                        break;

                    case "5":
                        listperson();
                        break;

                    case "6":
                        listpersonbycity();
                        break;

                    case "7":
                        Adressgroupbycountry();
                        break;

                    case "8":
                        Console.WriteLine("Exiting....");
                        return;

                    default:
                        Console.WriteLine("Invalid choice!!!");
                        break;

                }


            } while (choose != "9");
        }
        public static void addperson()
        {

            Console.WriteLine("Enter First Name: ");
            string firstname = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter the age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Home Address: ");
            string homeadress = Console.ReadLine();
            Console.WriteLine("Enter Work Address: ");
            string workaddress = Console.ReadLine();
            Console.WriteLine("Enter Roll Number: ");
            int rollnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Building: ");
            string building = Console.ReadLine();
            Console.WriteLine("Enter street :");
            string street = Console.ReadLine();
            Console.WriteLine("Enter Phone number: ");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter Email: ");
            string email = Console.ReadLine();
            Console.WriteLine("Enter city: ");
            string cityname = Console.ReadLine().ToLower();
            Console.WriteLine("Enter City ID: ");
            string cityid = Console.ReadLine();
            Console.WriteLine("Enter Country: ");
            string countryname = Console.ReadLine().ToLower();
            Console.WriteLine("Enter Country ID: ");
            string countryid = Console.ReadLine();
            person.Add(new Country(firstname, lastname, age, homeadress, workaddress, rollnumber, building, street, phone, email, cityid, cityname, countryid, countryname));
            count++;
            Console.WriteLine("Added Successfullly");
            return;
        }
        public static void Display()
        {

            if (count == 0)
            {
                Console.WriteLine("No person to display!!!");
                return;
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"\nPerson{i + 1}");
                    person[i].display();
                }
            }
        }

        public static void listperson()
        {
            Console.WriteLine("*****-------*****");
            var query2 = person.FindAll(e => e.Age > 25);
            foreach (var young in query2)
            {
                Console.WriteLine($"Name: {young.FirstName + young.LastName} Age:{young.Age} Country: {young.CountryName}");
            }

        }

        public static void listpersonbycity()
        {
            Console.WriteLine("*****-------*****");
            Console.WriteLine("\nEnter city to find persons: ");
            string city = Console.ReadLine().ToLower();

            var query = person.FindAll(e => e.CityName == city && e.Age < 20);
            if (query.Any())
            {
                foreach (var q1 in query)
                {
                    Console.WriteLine($"Name:{q1.FirstName + q1.LastName}  Age:{q1.Age} Country: {q1.CountryName}");
                }
            }
            else
            {
                Console.WriteLine("\n No such person found!!");
            }
        }

        public static void Adressgroupbycountry()
        {
            Dictionary<Country, List<Person>> dic = new Dictionary<Country, List<Person>>();

            var query = person.GroupBy(e => e.CountryName);

            foreach (var q1 in query)
            {
                var list1 = q1.Key;
                var q7 = q1.Where(e => e.CountryName == q1.Key).Select(e => new { e.CountryName, e.CountryId });
                foreach (var c1 in q7)
                {
                    Console.WriteLine($"Countryname: {c1.CountryName} {c1.CountryId}");
                }
                Country country1 = new Country();
                List<Person> person1 = new List<Person>();
                foreach (var q2 in q1)
                {

                    country1.CountryId = q2.CountryId;
                    country1.CountryName = q2.CountryName;
                    person1.Add(q2);
                }
                dic.Add(country1, person1);
            }




        }


    }
}







