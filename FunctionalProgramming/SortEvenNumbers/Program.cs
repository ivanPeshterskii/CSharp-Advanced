using System;
using System.Linq;

var numbers = Console
    .ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .Where(n=>n%2==0)
    .OrderBy(n => n)
    .ToArray();

Console.WriteLine(string.Join(", ", numbers));
Console.ReadKey();