using System;
using System.Collections.Generic;
using System.Linq;
namespace SpecificElements
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            ints.Add(100);
            ints.Add(122);
            ints.Add(30);
            ints.Add(45);
            ints.Add(105);
            ints.Add(120);

            var query_int = from e in ints
                            where e > 50
                            select e;
            Console.WriteLine("query used display");
            foreach (var e in query_int)
            {
                Console.WriteLine(e);
            }
            var method_int = ints.Where(e => e > 50).Select(e => e);
            Console.WriteLine("method syntax used display");
            foreach (var e in query_int)
            {
                Console.WriteLine(e);
            }

            //List<Student> students = new List<Student>();
            //Student stu_obj = new Student("abc", 50);
            //Student stu_obj1 = new Student("xyz", 100);
            //Student stu_obj2 = new Student("ert", 90);
            //Student stu_obj3 = new Student("oop", 70);
            //Student stu_obj4 = new Student("xrz", 99);
            //students.Add(stu_obj);
            //students.Add(stu_obj1);
            //students.Add(stu_obj2);
            //students.Add(stu_obj3);
            //students.Add(stu_obj4);

            //var query_stu = from e in students
            //                where e.Score > 80
            //                select e.Name;
            //Console.WriteLine("query used display");
            //foreach (var e in query_stu)
            //{
            //    Console.WriteLine(e);
            //}
            //var method_stu = students.Where(e => e.Score > 80).Select(e => e.Name);
            //Console.WriteLine("method syntax used display");
            //foreach (var e in query_stu)
            //{
            //    Console.WriteLine(e);
            //}

            List<string> names = new List<string>();
            names.Add("Product");
            names.Add("Producer");
            names.Add("Promote");
            names.Add("Demote");
            names.Add("Calculate");

            var query_name = from e in names
                             where e.Contains("pro")
                             select e;
            Console.WriteLine("query used display");
            foreach (var e in query_name)
            {
                Console.WriteLine(e);
            }

            var method_name = names.Where(e => e.Contains("pro")).Select(e => e);
            Console.WriteLine("method syntax used display");
            foreach (var e in method_name)
            {
                Console.WriteLine(e);
            }

            List<Employee> employees = new List<Employee>();
            Employee emp = new Employee(12, "abc", 2012);
            Employee emp1 = new Employee(14, "rty", 1999);
            Employee emp2 = new Employee(2, "abc", 2001);
            Employee emp3 = new Employee(3, "abc", 2012);
            Employee emp4 = new Employee(30, "abc", 2000);
            employees.Add(emp);
            employees.Add(emp1);
            employees.Add(emp2);
            employees.Add(emp3);
            employees.Add(emp4);

            var query_emp = from e in employees
                            where e.Year >= 2000
                            select e.Name;
            Console.WriteLine("query used display");
            foreach (var e in query_emp)
            {
                Console.WriteLine(e);
            }

            var method_emp = employees.Where(e => e.Year > 2000).Select(e => e.Name);
            Console.WriteLine("method syntax used display");
            foreach (var e in method_emp)
            {
                Console.WriteLine(e);
            }

            List<object> obj_list = new List<object> { 1, 2, "qwe", 34.6, 90.00000005, "dfg" };

            var obj_query = from e in obj_list
                            where e is int
                            select e;
            foreach (var obj in obj_query)
            {
                Console.WriteLine("");
            }

            var ob_query = obj_list.OfType<int>().Select(e => e);

            List<int> num = new List<int>();
            num.Add(12);
            num.Add(39);
            var oder = num.OrderBy(e => e).Select(e => e);
            var dec = num.OrderByDescending(e => e).Select(e => e);

            List<Student> student = new List<Student>();
            Student ob_stu = new Student("Jan", 100, 123);
            Student ob_stu1 = new Student("Feb", 60, 143);
            Student ob_stu2 = new Student("Mar", 90, 100);
            Student ob_stu3 = new Student("Apr", 78, 111);
            Student ob_stu4 = new Student("May", 84, 131);
            Student ob_stu5 = new Student("Jun", 55, 154);
            Student ob_stu6 = new Student("Jul", 84, 161);
            student.Add(ob_stu1);
            student.Add(ob_stu2);
            student.Add(ob_stu3);
            student.Add(ob_stu4);
            student.Add(ob_stu5);
            student.Add(ob_stu);

            var stu = student
                .OrderByDescending(item => item.Score)
                .ThenByDescending(item => item.Id)
                .Select(item => (item.Name, item.Score));
            foreach(var s in stu)
            {
                Console.WriteLine("Name  : {0}  Score  : {1}" ,s.Name, s.Score);
            }

            List<int> numbers = new List<int>();
            numbers.Add(23);
            numbers.Add(50);
            numbers.Add(56);
            numbers.Add(65);
            numbers.Add(77);
            numbers.Add(97);
            numbers.Add(83);

            var nums = numbers
                .OrderByDescending(n => n)
                .Select(n => n);
            Console.WriteLine("Numbers in Descendin order");
            foreach(var nm in nums)
            {
                Console.WriteLine(nm);
            }
            var nums_asc = numbers
                .OrderBy(n => n)
                .Select(n => n);
            Console.WriteLine("Numbers in Ascending order");
            foreach (var nm in nums_asc)
            {
                Console.WriteLine(nm);
            }
            var num_order = numbers
                .Where(n => n > 50)
                .Select(n => n);
            Console.WriteLine("Numbers more than 50");
            foreach (var nm in num_order)
            {
                Console.WriteLine(nm);
            }
        }
    }
}
