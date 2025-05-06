internal class Program
{
    private static void Main(string[] args)
    {
       Queue<string> elements = new Queue<string>();

        elements.Enqueue("radhi");
        elements.Enqueue("kian");
        elements.Enqueue("krish");
        elements.Enqueue("renya");
        elements.Enqueue("seenu");

        elements.Dequeue();
        elements.Dequeue();

        foreach (var element in elements)

        {
            Console.WriteLine(element);
        }
    }
}