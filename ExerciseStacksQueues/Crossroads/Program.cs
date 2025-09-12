using System;
using System.Collections.Generic;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenDuration = int.Parse(Console.ReadLine());
            int freeWindow = int.Parse(Console.ReadLine());

            Queue<string> cars = new Queue<string>();
            int totalPassed = 0;

            while (true)
            {
                string input = Console.ReadLine();

                if (input == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{totalPassed} total cars passed the crossroads.");
                    break;
                }
                else if (input == "green")
                {
                    int time = greenDuration;

                    while (time > 0 && cars.Count > 0)
                    {
                        string car = cars.Peek();

                        if (car.Length <= time)
                        {
                            time -= car.Length;
                            cars.Dequeue();
                            totalPassed++;
                        }
                        else
                        {
                            int remaining = car.Length - time;

                            if (remaining <= freeWindow)
                            {
                                cars.Dequeue();
                                totalPassed++;
                              
                                break;
                            }
                            else
                            {
                                char hitChar = car[time + freeWindow];
                                Console.WriteLine("A crash happened!");
                                Console.WriteLine($"{car} was hit at {hitChar}.");
                                return;
                            }
                        }
                    }
                }
                else
                {
                    cars.Enqueue(input);
                }
            }
            Console.ReadKey();
        }
    }
}


