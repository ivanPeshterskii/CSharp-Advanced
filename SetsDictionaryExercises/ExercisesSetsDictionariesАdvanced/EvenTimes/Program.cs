using System;
using System.Collections.Generic;
using System.Linq;

namespace EvenTimes;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        var dictionary = new Dictionary<int, int>();

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if (!dictionary.ContainsKey(number))
            {
                dictionary[number] = 1;
            }
            else
            {
                dictionary[number]++;
            }

        }

        foreach (var (num, count) in dictionary)
        {
            if (count % 2 == 0)
            {
                Console.WriteLine(num);
            }
        }

        Console.ReadKey();
    }
}

