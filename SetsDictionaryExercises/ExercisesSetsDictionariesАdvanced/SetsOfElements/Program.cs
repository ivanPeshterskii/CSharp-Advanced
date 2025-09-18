using System;
using System.Collections.Generic;
using System.Linq;

namespace SetsOfElements;
class Program
{
    static void Main(string[] args)
    {
        var input = Console
            .ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        HashSet<int> first = new HashSet<int>();
        HashSet<int> second = new HashSet<int>();

        int n = input[0];
        int m = input[1];


        for(int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            first.Add(num);
        }

        for (int i = 0; i < m; i++)
        {
            int num = int.Parse(Console.ReadLine());
            second.Add(num);
        }

        List<int> result = new List<int>();

        foreach (var num in first)
        {
            if (second.Contains(num))
            {
                result.Add(num);
            }
        }

        Console.WriteLine(string.Join(" ",result));
    }
}

