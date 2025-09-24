using System;
using System.Collections.Generic;
using System.Linq;

List<int> numbers = Console
    .ReadLine()
    .Split(", ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

int count = numbers.Count;
int sum = numbers.Sum();

Console.WriteLine(count);
Console.WriteLine(sum);

