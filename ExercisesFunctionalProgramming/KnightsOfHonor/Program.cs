using System;
using System.Linq;

var names = Console
    .ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

Action<string> printFormated = name => Console.WriteLine("Sir " + name);

foreach (var knight in names)
{
    printFormated(knight);
}

Console.ReadKey();