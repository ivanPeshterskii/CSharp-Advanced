using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour;
class Program
{
    static void Main(string[] args)
    {
        int totalPumps = int.Parse(Console.ReadLine());

        Queue<int[]> pumps = new Queue<int[]>();

        for (int i = 0; i < totalPumps; i++)
        {
            var liters = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            pumps.Enqueue(liters);
        }
        while (true)
        {
            int position = 0;
            int fuel = 0;
            foreach (var pump in pumps)
            {
                var fuelInPump = pump[0];
                var distance = pump[1];

                fuel += fuelInPump - distance;

                if (fuel < 0)
                {
                    position++;
                    pumps.Enqueue(pumps.Dequeue());
                    break;
                }

            }

            if (fuel > 0)
            {
                Console.WriteLine(position);
                break;
            }
            Console.ReadKey();
        }
    }
}

