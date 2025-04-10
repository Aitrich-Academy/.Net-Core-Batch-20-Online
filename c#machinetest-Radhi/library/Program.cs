internal class Program
{
    struct Library_book
    {
        public int Book_id;
        public string Title;
        public string Author;
    }
    private static void Main(string[] args)
    {
        Library_book[] library = new Library_book[5];
        int ch = 0;
        string res = "";

        do
        {



            Console.WriteLine("1.Add details \n 2.Search \n 3.Exit");
            ch = Convert.ToInt32(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    {
                        Console.WriteLine("Enter details of 5 books");

                        for (int i = 0; i < 5; i++)
                        {
                            Console.WriteLine("enter the id of book");
                            library[i].Book_id = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("enter the Title of Book");
                            library[i].Title = Console.ReadLine();
                            Console.WriteLine("Enter the author of the Book");
                            library[i].Author = Console.ReadLine();
                            Console.WriteLine("----------------------------------");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("Enter Book ID to search");
                        int search = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < 5; i++)
                        {
                            if (search == library[i].Book_id)
                            {
                                Console.WriteLine($"Book Id:{library[i].Book_id}");
                                Console.WriteLine($"Book Title:{library[i].Title}");
                                Console.WriteLine($"Author:{library[i].Author}");

                            }
                        }
                        break;
                    }
                default:
                    Console.WriteLine("invalid");
                    break;
            }
            Console.WriteLine("Do you want to continue(y/n)");
            res = Console.ReadLine();
        } while (res == "y" || res == "Y");
    } 














                }
