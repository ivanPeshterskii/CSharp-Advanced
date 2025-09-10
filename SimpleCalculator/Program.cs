using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator;
class Program
{
    static void Main(string[] args)
    {
        var tokens =
            Console.ReadLine()
            .Split()
            .Reverse()
            .ToArray();

        var stack = new Stack<string>(tokens);


        bool isAddition = true;

        int sum = 0;

        while (stack.Count > 0)
        {
            var current = stack.Pop();

            if (current == "+")
            {
                isAddition = true;
            }
            else if (current == "-")
            {
                isAddition = false;
            }
            else
            {
                int number = int.Parse(current);

                if (!isAddition)
                {
                    number *= -1;
                }
                sum += number;
            }

            
        }

        Console.WriteLine(sum);
        Console.ReadKey();
    }
}
