using System;
using System.Collections.Generic;
using System.Linq;

namespace FashionBoutique;
class Program
{
    static void Main(string[] args)
    {
        int[] clothes =
            Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        int capacility = int.Parse(Console.ReadLine());

        Stack<int> clothesInRack = new Stack<int>(clothes);

        int racks = 1;
        int currentSum = 0;

        while (clothesInRack.Any())
        {
            int currentCloth = clothesInRack.Peek();

            if (currentSum + currentCloth <= capacility)
            {
                currentSum += clothesInRack.Pop();
            }
            else
            {
                racks++;
                currentSum = 0;
            }
        }

        Console.WriteLine(racks);
    }
}

