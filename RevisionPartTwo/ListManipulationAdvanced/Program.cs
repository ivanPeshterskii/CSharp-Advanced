using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationAdvanced;
class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = Console.ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        string commands = string.Empty;
        while ((commands = Console.ReadLine()) != "end")
        {
            string[] command = commands.Split(" ");

            string action = command[0];

            switch (action)
            {
                case "Contains":
                    int number = int.Parse(command[1]);
                    if (numbers.Contains(number))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No such number");
                    }
                    break;

                case "PrintEven":
                    Console.WriteLine(string.Join(" ",numbers.Where(n=>n%2==0)));
                    break;

                case "PrintOdd":
                    Console.WriteLine(string.Join(" ", numbers.Where(n => n % 2 != 0)));
                    break;

                case "GetSum":
                    Console.WriteLine(numbers.Sum());
                    break;

                case "Filter":
                    string condition = command[1];
                    number = int.Parse(command[2]);
                    List<int> filtered = numbers;
                    if (condition == "<")
                    {
                        filtered = numbers.Where(n => n < number).ToList();
                    }
                    else if (condition == ">")
                    {
                        filtered = numbers.Where(n => n > number).ToList();
                    }
                    else if (condition == ">=")
                    {
                        filtered = numbers.Where(n => n >= number).ToList();
                    }
                    else if (condition == "<=")
                    {
                        filtered = numbers.Where(n => n <= number).ToList();
                    }
                    Console.WriteLine(string.Join(" ",filtered));
                    break;
            }
        }
        Console.WriteLine(string.Join(" ", numbers));

        Console.ReadKey();
    }
}

