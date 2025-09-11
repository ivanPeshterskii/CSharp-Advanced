namespace AssociativeArray;
class Program
{
    static void Main(string[] args)
    {
        // Create and read dictioanry

        Dictionary<string, int> dayOfWeek = new()
        {
            {"Monday", 1 },
            {"Tuesday", 2 },
            {"Wednesday", 3 },
            {"Thursday", 4 },
            {"Friday", 5 },
            {"Saturday", 6 },
            {"Sunday", 7 }
        };
        
        Console.Write("Enter day of the week: ");
        string day = Console.ReadLine();
        Console.WriteLine($"The day is {dayOfWeek[day]}");

        Console.ReadKey();

    }
}

