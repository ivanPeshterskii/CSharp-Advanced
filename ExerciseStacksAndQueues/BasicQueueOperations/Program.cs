using System;
using System.Collections.Generic;
using System.Linq;

namespace BasicQueueOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>();

            int n = numbers[0];
            int s = numbers[1];
            int x = numbers[2];

            var inputNumbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(inputNumbers[i]);
            }

            for (int i = 0; queue.Any() && i < s; i++)
            {
                queue.Dequeue();
            }

            if (queue.Contains(x))
            {
                Console.WriteLine("true");
            }
            else if (queue.Any())
            {
                Console.WriteLine(queue.Min());
            }
            else
            {
                Console.WriteLine("0");
            }
        }
    }
}

