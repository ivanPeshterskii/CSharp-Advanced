using System;
using System.Linq;

namespace Arrays;

// ["0, 1, 2, 3, 4, 5, 6, 7, 8, 9"]
class Program
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        // Read array using for-loop

        Console.WriteLine("using for-loop");
        for (int i = 0; i < array.Length; i++)
        {
            
            Console.WriteLine(array[i]);
        }

        // Read array using foreach-loop

        Console.WriteLine("using foreach-loop");
        foreach (int number in array)
        {
            
            Console.WriteLine(number);
        }


        Console.WriteLine("By index");
        Console.WriteLine(array[6]);
        Console.ReadKey();
    }
}