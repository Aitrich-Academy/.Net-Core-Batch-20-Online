using static System.Formats.Asn1.AsnWriter;

internal class Program
{
    
    
        // Create Student Records using SortedList
        //Create a SortedList<int, string> to store student roll numbers and names. Allow the user to:
        //Add a student.
        //Delete a student by roll number.
        //Display all students sorted by roll number.

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

            Console.WriteLine("\n--- Student List (Sorted by ID) ---");
            foreach (var s in student)
            {
                Console.WriteLine($"ID: {s.Key}, Name: {s.Value}");
            }




        }
    }
    