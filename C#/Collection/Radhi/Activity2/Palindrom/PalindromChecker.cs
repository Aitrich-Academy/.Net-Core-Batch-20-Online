using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrom
{
    public class PalindromChecker
    {
        public  bool IsPalindrome(string input)
        {
            // Normalize input: remove non-alphanumeric and convert to lowercase
            string normalized = "";
            foreach (char c in input)
            {
                if (char.IsLetterOrDigit(c))
                    normalized += char.ToLower(c);
            }

            Stack<char> stack = new Stack<char>();
            Queue<char> queue = new Queue<char>();

            // Fill stack and queue
            foreach (char c in normalized)
            {
                stack.Push(c);
                queue.Enqueue(c);
            }

            // Compare characters from stack and queue
            while (stack.Count > 0)
            {
                if (stack.Pop() != queue.Dequeue())
                    return false;
            }

            return true;
        }
    }
}
