internal class Program
{
    static void Main()
    {
        SortedList<int, string> student = new SortedList<int, string>();

        Console.Write("Enter number of students: ");
        int count = int.Parse(Console.ReadLine());

        for (int i = 0; i < count; i++)
        {
            Console.Write($"Enter ID for student {i + 1}: ");
            int id = int.Parse(Console.ReadLine());

            Console.Write($"Enter name for student {i + 1}: ");
            string name = Console.ReadLine();

            if (!student.ContainsKey(id))
            {
                student.Add(id, name);
            }
            else
            {
                Console.WriteLine("ID already exists. Skipping...");
            }
        }

        Console.WriteLine("\n--- All Students (Sorted by ID) ---");
        foreach (var s in student)
        {
            Console.WriteLine($"ID: {s.Key}, Name: {s.Value}");
        }

        Console.WriteLine("\n--- Students with names starting with 'A' ---");
        foreach (var s in student)
        {
            if (s.Value.StartsWith("A", StringComparison.OrdinalIgnoreCase))
            {
                Console.WriteLine($"ID: {s.Key}, Name: {s.Value}");
            }
        }
    }
}