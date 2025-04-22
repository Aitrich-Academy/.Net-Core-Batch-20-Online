using Students_oops;
internal class Program
{
    private static void Main(string[] args)
    {
        Students student1 = new Students("Alfiya" ,101, "A");
        Students student2 = new Students("Anzal", 105, "A");

        student1.DisplayDetails();
        student2.DisplayDetails();
    }
}