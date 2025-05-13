using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter a word: ");
        string input = Console.ReadLine();

        Stack<char> stack = new Stack<char>();
        Queue<char> queue = new Queue<char>();

        foreach (char ch in input)
        {
            stack.Push(ch);
            queue.Enqueue(ch);
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

        if (isPalindrome)
            Console.WriteLine("The string is a palindrome.");
        else
            Console.WriteLine("The string is not a palindrome.");
    }
}