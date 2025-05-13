using System;
using System.Collections.Generic;

class Task
{
    public string Name { get; set; }
    public bool IsComplete { get; set; }

    public Task(string name)
    {
        Name = name;
        IsComplete = false;
    }

    public void MarkComplete()
    {
        IsComplete = true;
    }
}

class Program
{
    static void Main()
    {
        List<Task> todoList = new List<Task>();
        bool exit = false;

        while (!exit)
        {
            // Display Menu
            Console.WriteLine("\nTo-Do List Application");
            Console.WriteLine("1. Add Task");
            Console.WriteLine("2. Mark Task as Complete");
            Console.WriteLine("3. View Pending Tasks");
            Console.WriteLine("4. Exit");
            Console.Write("Choose an option: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    // Add Task
                    Console.Write("Enter task name: ");
                    string taskName = Console.ReadLine();
                    todoList.Add(new Task(taskName));
                    Console.WriteLine("Task added successfully.");
                    break;

                case "2":
                    // Mark Task as Complete
                    Console.Write("Enter task name to mark as complete: ");
                    string taskToComplete = Console.ReadLine();
                    Task task = todoList.Find(t => t.Name.Equals(taskToComplete, StringComparison.OrdinalIgnoreCase));

                    if (task != null && !task.IsComplete)
                    {
                        task.MarkComplete();
                        Console.WriteLine($"Task '{taskToComplete}' marked as complete.");
                    }
                    else
                    {
                        Console.WriteLine("Task not found or already completed.");
                    }
                    break;

                case "3":
                    // View Pending Tasks
                    Console.WriteLine("\nPending Tasks:");
                    foreach (var t in todoList)
                    {
                        if (!t.IsComplete)
                        {
                            Console.WriteLine($"- {t.Name}");
                        }
                    }
                    break;

                case "4":
                    // Exit
                    exit = true;
                    break;

                default:
                    Console.WriteLine("Invalid option. Please choose again.");
                    break;
            }
        }

        Console.WriteLine("Goodbye!");
    }
}