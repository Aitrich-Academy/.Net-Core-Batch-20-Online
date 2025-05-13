using Library;

internal class Program
{
    public static void Main(string[] args)
    {
        List<LibraryMember> members = new List<LibraryMember>
        {
            new StudentMember(1,"Alfiya"),
            new FacultyMember(2,"Anzal"),
            new StudentMember(3,"Subair"),
            new FacultyMember(4,"Ramla"),
            new FacultyMember(5,"Haseeba")
        };
        int overdueDays = 7;

        foreach(var member in members)
        {
            Console.WriteLine($"Member: {member.Name} ({member.GetType().Name})");
            Console.WriteLine($"Fine for the {overdueDays} overdue days are: ${member.CalculateFine(overdueDays)}");
            Console.WriteLine();
        }
    }
}