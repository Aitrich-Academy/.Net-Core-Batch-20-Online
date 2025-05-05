using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using testing;

internal class Program:ApplicationException
{
    public Program()
    {
    }

    public Program(string message)
        : base(message)
    {
    }

    public Program(string message, Exception inner)
        : base(message, inner)
    { }

    private static void Main(string[] args)
    {
       
        try
        {
            int a;
            int b;
            int result;

            Console.WriteLine("Enter first number : ");
            a = Convert.ToInt32(Console.ReadLine());
            if(a < 0)
            {
                throw new ApplicationException("Exception");
            }
            Console.WriteLine("Enter second number : ");
            b = Convert.ToInt32(Console.ReadLine());
            result = a/b;
            Console.WriteLine($"Result = {result}");

        }
        
    

        catch (ArithmeticException e1){ 
            Console.WriteLine(e1.Message);
        }
        catch(FormatException e2)
        {
            Console.WriteLine(e2.Message);
        }
        catch(Exception e)
        {
            Console.WriteLine(e.Message);
        }
        finally
        {
            Console.WriteLine("Exiting..");
        }

    }
}