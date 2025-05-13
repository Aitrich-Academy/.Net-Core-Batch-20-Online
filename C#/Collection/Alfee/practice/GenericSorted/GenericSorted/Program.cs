internal class Program
{
    private static void Main(string[] args)
    {
        SortedList<int, string> students = new SortedList<int, string>();

        students.Add(3, "Alfiya");
        students.Add(1, "Anood");
        students.Add(2, "Radhi");
        students.Add(4, "Remya");

        Console.WriteLine("Sorted Student List:");
        foreach(var student in students)
        {
            Console.WriteLine($"ID: {student.Key}, Name: {student.Value}");
        }
    }
}