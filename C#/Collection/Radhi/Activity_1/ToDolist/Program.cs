using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using ToDolist;
public class Program
{

    
    private static void Main(string[] args)
    {
        TaskItem task = new TaskItem();
        string choice;
        do
        {


            Console.WriteLine("enter your choice(1-2)");
            Console.WriteLine("1.AddTask 2.Mark task 3.pending task");
            string c = Console.ReadLine();
            switch (c)
            {
                case "1":
                    {
                        task.Addtask();
                        break;
                    }
                case "2":
                    {
                        task.Marktask();
                        break;
                    }
                case "3":
                    {
                        task.display();
                        break;
                    }
                default:
                    {
                        Console.WriteLine("invalid entry");
                        break;
                    }
            }
            Console.WriteLine("Do you want to continue(y/n)");
            choice= Console.ReadLine();
        }while (choice=="y"||choice=="Y");


                
                
        

       

    }
}