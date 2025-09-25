using System;
using System.Linq;

int[] numbers = Console
    .ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

Func<int[], int> printSmallestNumber = nums =>
{
    int min = nums[0];
    foreach (int n in nums)
    {
        if (n < min) { min = n; }
    }
    return min;
};

Console.WriteLine(printSmallestNumber(numbers));