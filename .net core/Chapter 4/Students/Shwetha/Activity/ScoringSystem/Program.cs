using System;
using System.Collections.Generic;
namespace ScoringSystem
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string choice;
            List<Student> list = new List<Student>();
            try
            {
                do
                {
                    Console.WriteLine("Score Board");
                    Console.WriteLine("1. Add Student details");
                    Console.WriteLine("2. Display Student details");
                    Console.WriteLine("3. Average score of Students");
                    Console.WriteLine("4. Ranks of Student");
                    Console.WriteLine("5. Remove Student");
                    Console.WriteLine("6. Exit");
                    Console.WriteLine("Select an option  from the above list");
                    string option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            {
                                StudentAdd();
                                break;
                            }
                        case "2":
                            {
                                Show();
                                break;
                            }
                        case "3":
                            {
                                Score();
                                break;
                            }
                        case "4":
                            {
                                StudentRank();
                                break;
                            }
                        case "5":
                            {
                                break;
                            }
                        case "6":
                            {
                                Console.WriteLine("Leaving...... please wait...");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("Invalid option......please try again");
                                break;
                            }
                    }
                    Console.WriteLine("Do you wish to continue .....(y/n)...?");
                    choice = Console.ReadLine();
                } while (choice == "Y" || choice == "y");
            }
       catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            void StudentAdd()
            {
                Console.WriteLine("You can enter the details here....");
                Console.WriteLine("::::::::::::::::::::::::::::::::::::::");
                Student student = new Student();
                Console.WriteLine("ENter the ID :");
                student.Id = Convert.ToInt32( Console.ReadLine());
                Console.WriteLine("ENter the Name:");
                student.Name = Console.ReadLine();
                Console.WriteLine("ENter the Age :");
                student.Age = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ENter the Total Score :");
                student.Score = Convert.ToDouble(Console.ReadLine());
                list.Add(student);
            }
            void Show()
            {
                Console.WriteLine("The Students list ..............");
                Console.WriteLine("::::::::::::::::::::::::::::::::::");
                foreach(Student student in list)
                {
                    Console.WriteLine(student.Id);
                    Console.WriteLine(student.Name);
                    Console.WriteLine(student.Age);
                    Console.WriteLine(student.Score);
                    Console.WriteLine("********************");
                }
            }
            void Score()
            {
                double Avg_Score = 0.0;
                int c = list.Count;
                try
                {
                    if (c == 0)
                    {
                        Console.WriteLine("No students in the list to calculate the average.");
                    }
                    Console.WriteLine("Average Score of the {0} students are :", c);
                    foreach (var item in list)
                    {
                        Avg_Score += item.Score;
                    }
                    Avg_Score /= c;
                    Console.WriteLine("Average Score is : {0}", Avg_Score);
                }
               catch(Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
            void StudentRank()
            {
                if (list.Count == 0)
                {
                    Console.WriteLine("No students in the list to rank.");
                }
                try
                {
                    var ranks = new List<Student>(list);
                    for(int i = 0; i < ranks.Count; i++)
                    {
                        for(int j = i + 1; j < ranks.Count; j++)
                        {
                            if (ranks[j].Score > ranks[i].Score)
                            {
                                var temp = ranks[i];
                                ranks[i] = ranks[j];
                                ranks[j] = temp;
                            }
                        }
                    }
                    int rank = 1;
                    foreach(var r in ranks)
                    {
                        Console.WriteLine("Rank  : {0}  ||  Name : {1}  || Mark  :{2}" ,rank , r.Name ,r.Score);
                        rank++;
                    }
                }
                catch (Exception exp)
                {
                    Console.WriteLine(exp.Message);
                }
            }
            void Remove_Student()
            {
                Show();
            }
        }
            
    }
}
