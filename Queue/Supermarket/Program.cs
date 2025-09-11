using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket;
class Program
{
    static void Main(string[] args)
    {
        Queue<string> queue = new Queue<string>();

        string command = string.Empty;
        while ((command=Console.ReadLine())!="End")
        {
            queue.Enqueue(command);

            if (command == "Paid")
            {
                Console.WriteLine(queue.Dequeue());
                queue.Clear();
            }

        }
        Console.WriteLine($"{queue.Count} people remaining.");
        Console.ReadKey();
        
    }
}

