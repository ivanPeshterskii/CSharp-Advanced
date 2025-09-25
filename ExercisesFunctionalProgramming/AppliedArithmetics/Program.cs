using System;
using System.Linq;

int[] numbers = Console
    .ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Func<int, int> add = num => num + 1;
Func<int, int> multiply = num => num * 2;
Func<int, int> subtract = num => num - 1;

string command = string.Empty;
while((command = Console.ReadLine()) != "end")
{
    switch (command)
    {
        case "add":
            numbers = numbers.Select(add).ToArray();
            break;

        case "multiply":
            numbers = numbers.Select(multiply).ToArray();
            break;

        case "subtract":
            numbers = numbers.Select(subtract).ToArray();
            break;

        case "print":
            Console.WriteLine(string.Join(" ", numbers));
            break;
    }
}

Console.ReadKey();

