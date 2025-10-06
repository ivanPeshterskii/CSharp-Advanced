using System;
namespace Tuple
{
	public class StartUp
	{
		public static void Main(string[] args)
		{
			string[] personTokens = Console
				.ReadLine()
				.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			string fullName = personTokens[0] + " " + personTokens[1];
			string address = personTokens[2];
			var tuple1 = new Tuple<string, string>(fullName, address);

			string[] beerTokens = Console
				.ReadLine()
				.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			string name = beerTokens[0];
			int count = int.Parse(beerTokens[1]);
			var tuple2 = new Tuple<string, int>(name, count);

			var input3 = Console
				.ReadLine()
				.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			int integer = int.Parse(input3[0]);
			double doubles = double.Parse(input3[1]);
			var tuple3 = new Tuple<int, double>(integer, doubles);

			Console.WriteLine(tuple1);
            Console.WriteLine(tuple2);
            Console.WriteLine(tuple3);
        }
	}
}

