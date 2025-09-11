using System;
using System.Collections.Generic;

namespace ReverseString;
class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();

        var stack = new Stack<char>();

        foreach (char character in input)
        {
            stack.Push(character);
        }

        while (stack.Count > 0)
        {
            Console.Write(stack.Pop());
        }
        Console.ReadKey();
    }
}
