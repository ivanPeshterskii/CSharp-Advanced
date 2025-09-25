using System;
using System.Collections.Generic;
using System.Linq;

List<int> numbers = Console
    .ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToList();

numbers.Reverse();

int devisor = int.Parse(Console.ReadLine());

Predicate<int> isNotDevisible = number => number % devisor != 0;

List<int> result = numbers.FindAll(isNotDevisible);

Console.WriteLine(string.Join(" ", result));
Console.ReadKey();
