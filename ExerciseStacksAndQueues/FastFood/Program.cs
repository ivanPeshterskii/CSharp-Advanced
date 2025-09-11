using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int foodQuantity = int.Parse(Console.ReadLine());

        int[] inputOrders = Console.ReadLine()
            .Split()
            .Select(int.Parse)
            .ToArray();

        Queue<int> orders = new Queue<int>(inputOrders);

        Console.WriteLine(orders.Max());

        while (orders.Any())
        {
            int currentOrder = orders.Peek();

            if (foodQuantity >= currentOrder)
            {
                foodQuantity -= orders.Dequeue();
            }
            else
            {
                Console.WriteLine("Orders left: " + string.Join(" ", orders));
                return;
            }
        }

        Console.WriteLine("Orders complete");
    }
}


