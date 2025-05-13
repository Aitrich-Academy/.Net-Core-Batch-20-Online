internal class Program
{
    private static void Main(string[] args)
    {
        Queue<string> customer = new Queue<string>();
        customer.Enqueue("Alfee");
        customer.Enqueue("Anood");
        customer.Enqueue("Radhi");
        customer.Enqueue("Abitha");

       //foreach(var item in customer)
       //{
       //     Console.WriteLine(item);
       //}
        Console.WriteLine($"{customer.Peek()}");

        while(customer.Count>0)
        {
            Console.WriteLine(customer.Count);
            string servedCustomer = customer.Dequeue();
            Console.WriteLine($"Serving: {servedCustomer}");
            Console.WriteLine($"Customer left in queue: {customer.Count}");
        }
    }
}