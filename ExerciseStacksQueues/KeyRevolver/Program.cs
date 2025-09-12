using System;
using System.Collections.Generic;
using System.Linq;

namespace KeyRevolver;
class Program
{
    static void Main(string[] args)
    {
        int bulletPrice = int.Parse(Console.ReadLine());
        int capacility = int.Parse(Console.ReadLine());

        int[] bullets = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Stack<int> stack = new Stack<int>(bullets);

        int[] locks = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Queue<int> queue = new Queue<int>(locks);

        int intelligenceValue = int.Parse(Console.ReadLine());

        int bulletsFired = 0;
        int bulletsInBArrel = capacility;

        while (stack.Any() && queue.Any())
        {
            int currentBullet = stack.Pop();
            int currentLock = queue.Peek();

            if (currentBullet <= currentLock)
            {
                Console.WriteLine("Bang!");
                queue.Dequeue();
            }
            else
            {
                Console.WriteLine("Ping!");
            }
            bulletsFired++;
            bulletsInBArrel--;
            if (bulletsInBArrel == 0)
            {
                Console.WriteLine("Reloading!");
                bulletsInBArrel = capacility;
            }
        }

        int sum = intelligenceValue - (bulletsFired * bulletPrice);

        if (!queue.Any())
        {
            Console.WriteLine($"{stack.Count} bullets left. Earned ${sum}");
        }
        else
        {
            Console.WriteLine($"Couldn't get through. Locks left: {queue.Count}");
        }
        Console.ReadKey();
    }
}

