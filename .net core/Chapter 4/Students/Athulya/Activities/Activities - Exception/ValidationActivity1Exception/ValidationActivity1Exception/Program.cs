using System.Reflection.Metadata;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using ValidationActivity1Exception.VlidationException;

namespace ValidationActivity1Exception
{
    internal class Program
    {
       
       
        static void Main(string[] args)
        {
            string choose;
            User[] user = new User[15];
          int index = 0;
            do
            {
                Console.WriteLine("+++++++++++++++");
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Display");
                Console.WriteLine("3.Exit");
                choose = Console.ReadLine();
                switch(choose)
                {
                    case "1":
                        if(index<user.Length)
                        {
                            user[index] = new User();
                            user[index].Add();
                            index++;
                            Console.WriteLine("Added Successfully");

                        }
                        else
                        {
                            Console.WriteLine("limits over");
                        }
                        break;
                    case "2":
                        Console.WriteLine("**********Display User Details *****");
                        //bool userd = false;
                        for (int i = 0; i < user.Length; i++)
                        {
                            if (user[i] != null)
                            {

                                Console.WriteLine("User  : {0}", i + 1);
                                user[i].Display();
                                Console.WriteLine("---------------------");
                                //userd = true;
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("Invalid");
                        break;
                }

            } while (choose != "3");
        }
    }
}



