using System;
using System.Collections.Generic;
using System.Linq;

namespace PeriodicTable;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        HashSet<string> chemical = new HashSet<string>();


        for (int i = 0; i < n; i++)
        {
            var input = Console
                .ReadLine()
                .Split()
                .ToArray();

            foreach (var item in input)
            {
                chemical.Add(item);
            }
        }

        var result = chemical
            .OrderBy(c => c);

        Console.WriteLine(string.Join(" ",result));
        Console.ReadKey();
    }
}

