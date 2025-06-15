using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ToDolist
{
    public class TaskItem
    {
        List<string> todo = new List<string>();
        public void Addtask()
        {

            Console.WriteLine(" how many number of task to add");
            int count = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter your task");

            for (int i = 0; i < count; i++)

            {
                todo.Add(Console.ReadLine());
            }
        }

        public void Marktask()
        {
            int i = 0;

            foreach (string item in todo)

            {
                
                Console.WriteLine($"{i} :{item}");
                i++;
            }

            Console.WriteLine("enter the task number to mark");
            int marked=Convert.ToInt32(Console.ReadLine());
            for (int j = 0; j < todo.Count; j++)
        
            
            {
                string item = todo[j];
                int s = todo.IndexOf(item);

                if (s == marked)
                {
                   todo.Remove(item);
                    Console.WriteLine("marked succcessfully");
                }
            }

        }

        public void display()
        {
            foreach(string item in todo)
            {
                Console.WriteLine(item);
            }
        }

            
                

          

       
       
    }
}
