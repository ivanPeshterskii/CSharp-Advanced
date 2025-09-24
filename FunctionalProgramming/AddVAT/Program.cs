using System;
using System.Linq;

double[] numbers = Console
    .ReadLine()
    .Split(", ")
    .Select(double.Parse)
    .ToArray();

Func<double, double> VAT = price => price * 1.20;

foreach (var price in numbers)
{
    double priceWithVar = VAT(price);
    Console.WriteLine($"{priceWithVar:f2}");
}
Console.ReadKey();

