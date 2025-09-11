using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            string[] command = Console.ReadLine().Split();

            if (command[0] == "1")
            {
                int number = int.Parse(command[1]);
                stack.Push(number);
            }
            else if (command[0] == "2")
            {
                if (stack.Any())
                {
                    stack.Pop();
                }
            }
            else if (command[0] == "3")
            {
                if (stack.Any())
                {
                    Console.WriteLine(stack.Max());
                }
            }
            else if (command[0] == "4")
            {
                if (stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
            }
        }

        Console.WriteLine(string.Join(", ", stack));
    }
}


