using System;
using System.Collections.Generic;
using System.Linq;

namespace HotPotato;
class Program
{
    static void Main(string[] args)
    {
        string[] names =
            Console.ReadLine()
            .Split()
            .ToArray();

        int n = int.Parse(Console.ReadLine());

        Queue<string> queue = new Queue<string>(names);

        while (queue.Count > 1)
        {
            for(int i = 0; i < n - 1; i++)
            {
                var currentKid = queue.Dequeue();
                queue.Enqueue(currentKid);
            }
            Console.WriteLine($"Removed {queue.Dequeue()}");
        }
        Console.WriteLine($"Last is {queue.Dequeue()}");
        Console.ReadKey();
    }
}

