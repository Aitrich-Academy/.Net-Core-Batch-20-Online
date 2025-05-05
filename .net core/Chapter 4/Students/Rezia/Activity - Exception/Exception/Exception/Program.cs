internal class Program
{
    private static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter first number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter secong number");
            int b = Convert.ToInt32(Console.ReadLine());
           
          
          int  result = a / b;
                Console.WriteLine($"Result is  {result}");
        }
        catch (FormatException e)
        {
            Console.WriteLine ("Format Exception is :" +e.Message);
        }
        catch (ArithmeticException e) {
            Console.WriteLine("Arithmetic Exception" + e.Message);
        }
        catch (Exception ex)
        {
            Console.WriteLine("ex.Message");
        }
        finally
        {
            Console.WriteLine("Do you wnt to continue");
        }
    }
}