using System;
using System.Linq;

string text = Console.ReadLine();

string[] words = text.Split(' ', StringSplitOptions.RemoveEmptyEntries);

foreach (var word in words)
{
    if (char.IsUpper(word[0]))
    {
        Console.WriteLine(word);
    }
}

Console.ReadKey();
