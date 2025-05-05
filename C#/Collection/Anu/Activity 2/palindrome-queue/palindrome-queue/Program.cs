using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome_queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine().ToLower();

            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            foreach (char c in str)
            {
                if (char.IsLetterOrDigit(c)) // Only letters and digits
                {
                    stack.Push(c);
                    queue.Enqueue(c);
                }
            }

            bool isPalindrome = true;

            while (stack.Count > 0)
            {
                if (stack.Pop() != queue.Dequeue())
                {
                    isPalindrome = false;
                    break;
                }
            }

            Console.WriteLine(isPalindrome ? "Palindrome" : "Not a palindrome");
        }
    }
    }

