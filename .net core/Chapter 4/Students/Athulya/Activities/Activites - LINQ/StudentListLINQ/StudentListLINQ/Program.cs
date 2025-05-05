namespace StudentListLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> student = new List<Student>();
            string ch, option;
            do
            {

                try
                {
                    Console.WriteLine("1.Add");
                    Console.WriteLine("2.Find");
                    Console.WriteLine("choice...");
                    option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            Add();
                            break;
                        case "2":
                            Find();
                            break;
                        default:
                            Console.WriteLine("invalid");
                            break;

                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Console.WriteLine("Do you want continue: Y/N");

                ch = Console.ReadLine();

            } while (ch == "y" || ch == "Y");



            void Add()
            {
                Student students = new Student();
                Console.WriteLine("Enter ID :");
                students.Id = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter name :");
                students.Name = Console.ReadLine();
                student.Add(students);
            }
            void Find()
            {
                var linqquery = from e in student
                                where e.Id == 2
                                select e;
                foreach (var i in linqquery)
                {
                    Console.WriteLine(i.Name);
                }
                foreach (var item in student)
                {
                    if (item.Id == 2)
                    {
                        Console.WriteLine(item.Name);
                    }
                }
            }
        }
    }
}


