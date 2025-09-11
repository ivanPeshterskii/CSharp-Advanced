using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int[] numbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int N = numbers[0]; 
        int S = numbers[1]; 
        int X = numbers[2]; 

        int[] inputNumbers = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Stack<int> stack = new Stack<int>();

        for (int i = 0; i < N; i++)
        {
            stack.Push(inputNumbers[i]);
        }

        for (int i = 0; i < S && stack.Any(); i++)
        {
            stack.Pop();
        }

        
        if (stack.Contains(X))
        {
            Console.WriteLine("true");
        }
        else if (stack.Any())
        {
            Console.WriteLine(stack.Min());
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}

