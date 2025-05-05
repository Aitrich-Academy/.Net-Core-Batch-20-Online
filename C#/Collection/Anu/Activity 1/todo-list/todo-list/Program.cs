using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace todo_list
{
    public class Program
    {
        static List<string> tasks = new List<string>();
        static List<bool> isCompleted = new List<bool>();
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("\n--- SIMPLE TODO LIST ---");
                Console.WriteLine("1. Add Task");
                Console.WriteLine("2. Mark Task as Complete");
                Console.WriteLine("3. View Pending Tasks");
                Console.WriteLine("4. Exit");
                Console.Write("Enter your choice: ");

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        AddTask();
                        break;
                    case "2":
                        MarkTaskAsComplete();
                        break;
                    case "3":
                        ViewPendingTasks();
                        break;
                    case "4":
                        Console.WriteLine("Exiting program...");
                        return;
                    default:
                        Console.WriteLine("Invalid choice.");
                        break;
                }
            }
        }
        static void AddTask()
        {
            Console.Write("Enter task: ");
            string task = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(task))
            {
                tasks.Add(task);
                isCompleted.Add(false);
                Console.WriteLine("Task added.");
            }
            else
            {
                Console.WriteLine("Task cannot be empty.");
            }
        }

        static void MarkTaskAsComplete()
        {
            Console.WriteLine("\n--- Pending Tasks ---");
            int count = 0;
            for (int i = 0; i < tasks.Count; i++)
            {
                if (!isCompleted[i])
                {
                    count++;
                    Console.WriteLine($"{count}. {tasks[i]} (Task #{i + 1})");
                }
            }

            if (count == 0)
            {
                Console.WriteLine("No pending tasks.");
                return;
            }

            Console.Write("Enter the task number to mark as complete: ");
            if (int.TryParse(Console.ReadLine(), out int taskNumber) && taskNumber >= 1 && taskNumber <= tasks.Count)
            {
                if (!isCompleted[taskNumber - 1])
                {
                    isCompleted[taskNumber - 1] = true;
                    Console.WriteLine("Task marked as complete.");
                }
                else
                {
                    Console.WriteLine("Task is already completed.");
                }
            }
            else
            {
                Console.WriteLine("Invalid task number.");
            }
        }

        static void ViewPendingTasks()
        {
            Console.WriteLine("\n--- Pending Tasks ---");
            bool hasPending = false;
            for (int i = 0; i < tasks.Count; i++)
            {
                if (!isCompleted[i])
                {
                    Console.WriteLine($"{i + 1}. {tasks[i]}");
                    hasPending = true;
                }
            }

            if (!hasPending)
            {
                Console.WriteLine("No pending tasks.");
            }
        } 

    }
}

