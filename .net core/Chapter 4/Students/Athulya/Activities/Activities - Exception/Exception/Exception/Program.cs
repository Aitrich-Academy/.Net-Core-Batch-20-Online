
using SampleException.Exceptions;

namespace Sampleexception

{
    internal class Program
    {
      private  static void Main(string[] args)
        {
            try
            {
                int x, y, z;
               
                Console.WriteLine("enter first value:");
                x = Convert.ToInt32(Console.ReadLine());
                //Console.WriteLine("number is" + x);
                if(x==2)
                {
                    throw new Nmber2Exception();
                }
                Console.WriteLine("Enter second number");
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("number is" + y);

                int s = x / y;
            }
            catch(ArithmeticException e)
            {
                //Console.WriteLine("Exception occured");
                Console.WriteLine("Arithematic exception :"+e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Formate exception" + e.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("in exception" +ex.Message);
            }
            finally
            {
                Console.WriteLine("Do you want continues");
            }
        }
    }
}
