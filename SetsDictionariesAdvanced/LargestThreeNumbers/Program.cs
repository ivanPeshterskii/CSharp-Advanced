namespace LargestThreeNumbers;
class Program
{
    static void Main(string[] args)
    {
        var inputNumbers = Console
            .ReadLine()
            .Split(" ", StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToArray();

        var result = inputNumbers
            .OrderByDescending(x => x)
            .Take(3)
            .ToArray();

        for (int i = 0; i < result.Length; i++)
        {
            Console.Write(result[i]+ " ");
        }

    }
}

