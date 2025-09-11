using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Queue<string> queue = new Queue<string>();
        int count = 0;

        string command = "";
        while ((command = Console.ReadLine())!= "end")
        {
            if (command == "green")
            {
                for (int i = 0; i < n; i++)
                {
                    if (queue.Any())
                    {
                        string car = queue.Dequeue();
                        Console.WriteLine($"{car} passed!");
                        count++;
                    }
                }
            }
            else
            {
                queue.Enqueue(command);
            }
        }
        Console.WriteLine($"{count} cars passed the crossroads.");
        Console.ReadKey();
    }
}

