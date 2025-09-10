using System;
using System.Collections.Generic;
using System.Linq;

namespace StackSum;
class Program
{
    static void Main(string[] args)
    {
        var numbers =
            Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        var stack = new Stack<int>(numbers);

        string command = string.Empty;

        while (true)
        {
            command = Console.ReadLine().ToLower();
            if (command.StartsWith("end"))
            {
                break;
            }

            string[] tokens = command.Split();

            if (tokens[0].StartsWith("add"))
            {
                stack.Push(int.Parse(tokens[1]));
                stack.Push(int.Parse(tokens[2]));
            }
            else if (tokens[0].StartsWith("remove"))
            {
                var countOfRemoved = int.Parse(tokens[1]);

                for (int i = 0; i < countOfRemoved; i++)
                {
                    stack.Pop();
                }
            }
        }

        Console.WriteLine($"Sum {stack.Sum()}");
        Console.ReadKey();
    }
}
