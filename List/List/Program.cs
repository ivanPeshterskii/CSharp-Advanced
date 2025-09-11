using System;
using System.Collections.Generic;
using System.Linq;


//["1,2,3,4,5,6,7,8,9"]

namespace List;
class Program
{
    static void Main(string[] args)
    {
        // Empty list
        List<int> numbers = new();

        // Fill the list from the console
        numbers = Console.ReadLine()
            .Split(",",StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        numbers.Add(10);
        numbers.Remove(5);
        numbers.Insert(2, -3);

        // Print by foreach-loop
        Console.WriteLine("Printed by foreach-loop: ");
        foreach (var item in numbers)
        {
            Console.WriteLine(item);
        }
        // Prent by string.Joing
        Console.WriteLine("Printed by string.Join: ");
        Console.WriteLine(string.Join(", ",numbers));



        // Acces 1  by its index
        Console.WriteLine(numbers[0]);


        Console.ReadKey();
    }
}

