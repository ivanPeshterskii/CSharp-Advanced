using System;
using System.Linq;

namespace LadybugsMovement;
class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int[] filed = new int[size];

        int[] initialIndexes = Console.ReadLine()
            .Split(" ",StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        foreach (int index in initialIndexes)
        {
            if (index >= 0 && index < size)
            {
                filed[index] = 1;
            }
        }

        string command = string.Empty;
        while ((command = Console.ReadLine()) != "end")
        {
            string[] parts = command.Split();
            int startIndex = int.Parse(parts[0]);
            string direction = parts[1];
            int length = int.Parse(parts[2]);

            if (!(startIndex >= 0 && startIndex < size && filed[startIndex]!=0))
            {
                continue;
            }

            filed[startIndex] = 0;

            int position = startIndex;

            while (true)
            {
                if (direction == "right")
                {
                    position += length;
                }
                else if (direction == "left")
                {
                    position -= length;
                }

                if (position < 0 || position >= size)
                {
                    break;
                }

                if (filed[position] == 0)
                {
                    filed[position] = 1;
                    break;
                }
            }
        }

        Console.WriteLine(string.Join(", ",filed));
        Console.ReadKey();
    }
}

