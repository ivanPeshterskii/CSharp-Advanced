using System;
using System.Collections.Generic;
using System.Linq;

namespace Queue;
class Program
{
    static void Main(string[] args)
    {
        int[] numbers =
            Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Queue<int> queue = new Queue<int>(numbers);
        List<int> result = new List<int>();

        for (int i = 0; i < numbers.Length; i++)
        {
            var current = queue.Dequeue();
            if (current % 2 == 0)
            {
                result.Add(current);
            }
        }
        Console.WriteLine(string.Join(", ",result));
        Console.ReadKey();
    }
}

