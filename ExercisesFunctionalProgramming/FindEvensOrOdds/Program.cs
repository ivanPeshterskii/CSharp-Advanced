using System;
using System.Linq;

int[] numbers = Console
    .ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

string filterBy = Console.ReadLine();

Predicate<int> filter;
if(filterBy == "even")
{
    filter = n => n % 2 == 0;
}
else
{
    filter = n => n % 2 != 0;
}

for (int i = numbers[0]; i <= numbers[1]; i++)
{
    if (filter(i))
    {
        Console.Write(i + " ");
    }
}
Console.ReadKey();
