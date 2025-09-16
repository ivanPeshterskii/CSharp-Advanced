namespace ProductShop;
class Program
{
    static void Main(string[] args)
    {
        var dictionary = new SortedDictionary<string, Dictionary<string, double>>();

        string command = string.Empty;
        while((command = Console.ReadLine()) != "Revision")
        {
            string[] input = command.Split(new[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries).ToArray();

            var shop = input[0];
            var product = input[1];
            var price = double.Parse(input[2]);

            if (!dictionary.ContainsKey(shop))
            {
                dictionary[shop] = new Dictionary<string, double>();
            }

            dictionary[shop][product] = price;
        }

        foreach (var(shop, product) in dictionary)
        {
            Console.WriteLine($"{shop}->");
            foreach (var (productEX, price) in product)
            {
                Console.WriteLine($"Product: {product}, Price {price}");
            }
        }
        Console.ReadKey();
    }
}

