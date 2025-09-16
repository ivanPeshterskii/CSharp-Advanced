namespace CountSameValuesArray;
class Program
{
    static void Main()
    {
        double[] array = Console
            .ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(double.Parse)
            .ToArray();

        var numbersInCount = new Dictionary<double, int>();

        foreach (var number in array)
        {
            if (!numbersInCount.ContainsKey(number))
            {
                numbersInCount[number] = 1;
            }
            else
            {
                numbersInCount[number]++;
            }
            
        }

        foreach (var entry in numbersInCount)
        {
            var key = entry.Key;
            var value = entry.Value;

            Console.WriteLine($"{key} - {value} times");
        }
        Console.ReadKey();
    }
}

