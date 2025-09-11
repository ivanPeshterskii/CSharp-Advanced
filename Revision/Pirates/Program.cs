using System;
using System.Collections.Generic;

namespace Pirates.Town;
class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, Town> cities = new Dictionary<string, Town>();

        string inputOne = string.Empty;
        while((inputOne = Console.ReadLine())!= "Sail")
        {
            string[] tokens = inputOne.Split("||");

            string name = tokens[0];
            int population = int.Parse(tokens[1]);
            int gold = int.Parse(tokens[2]);

            if (cities.ContainsKey(name))
            {
                cities[name].Population += population;
                cities[name].Gold += gold;
            }
            else
            {
                cities[name] = new Town(name, population, gold);
            }
        }

        string inputTwo = string.Empty;
        while((inputTwo = Console.ReadLine())!= "End")
        {
            string[] tokens = inputTwo.Split("=>");

            string action = tokens[0];
            string name = tokens[1];

            switch (action)
            {
                case "Plunder":
                    int population = int.Parse(tokens[2]);
                    int gold = int.Parse(tokens[3]);
                    cities[name].Plunder(population, gold);

                    if (cities[name].Destroyed())
                    {
                        Console.WriteLine($"{name} has been wiped off the map!");
                        cities.Remove(name);
                    }

                    break;

                case "Prosper":
                    gold = int.Parse(tokens[2]);
                    cities[name].Propsper(gold);
                    break;
            }
        }

        if (cities.Count > 0)
        {
            Console.WriteLine($"Ahoy, Captain! There are {cities.Count} wealthy settlements to go to:");
            foreach (var item in cities.Values)
            {
                Console.WriteLine(item);
            }
            
        }
        else
        {
            Console.WriteLine("Ahoy, Captain! All targets have been plundered and destroyed!");
        }
    }
}