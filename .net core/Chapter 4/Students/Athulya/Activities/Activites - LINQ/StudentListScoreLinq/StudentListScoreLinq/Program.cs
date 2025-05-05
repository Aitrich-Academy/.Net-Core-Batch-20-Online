namespace StudentListScoreLinq
{
    internal class Program
    {
        static void Main(string[] args)
        {
           //List<student> studentList = new List<student>();
           // student students = new student(85,"ha");
           // student students1 = new student(90, "hi");
           // student students2 = new student(99, "halo");

           // studentList.Add(students);
           // studentList.Add(students1);
           // studentList.Add(students2);

           // var x = from e in studentList
           //         where e.Score>80
           //         select e.Name;
           // foreach(var item in x)
           // {
           //     Console.WriteLine(item);
           // }

            List<student> list = new List<student>() { new student(80,"athul"),new student(80,"shijina"),new student(82,"shaju")};

            //var q = from e in list
            //        where e is int
            //        select e;
            //foreach(var e in q)
            //{
            //    Console.WriteLine(e);
            //}
            
            var w=list.OrderBy(e=>e.Score).ThenByDescending(e=>e.Name).Select(e=>e);
            foreach (var e in w)
            {
                Console.WriteLine(e.Score);
                Console.WriteLine(e.Name);
            }

        }
    }
}
