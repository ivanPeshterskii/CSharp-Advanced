using System;
using System.Collections.Generic;
using System.Linq;

namespace SongsQueue;
class Program
{
    static void Main(string[] args)
    {
        var songs =
            Console.ReadLine()
            .Split(", ")
            .ToArray();

        Queue<string> queue = new Queue<string>(songs);

        string commands = string.Empty;
        while (queue.Any())
        {
            commands = Console.ReadLine();
            string[] tokens = commands.Split().ToArray();

            switch (tokens[0])
            {
                case "Play":
                    queue.Dequeue();
                    break;

                case "Add":
                    string song = commands.Substring(4);
                    if (queue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        queue.Enqueue(song);
                    }
                    break;

                case "Show":
                    Console.WriteLine(string.Join(", ", queue));
                    break;
            }
        }
        Console.WriteLine("No more songs!");
        Console.ReadKey();
    }
}

