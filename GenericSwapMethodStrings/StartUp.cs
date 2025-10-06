using System;
namespace GenericSwapMethodStrings
{
	public class StartUp
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			List<Box<string>> boxes = new List<Box<string>>();
			for (int i = 0; i < n; i++)
			{
				string input = Console.ReadLine();
				boxes.Add(new Box<string>(input));
			}

			var indexes = Console
				.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();

			int firstIndex = indexes[0];
            int secondIndex = indexes[1];

			Swap(boxes, firstIndex, secondIndex);

			foreach (var box in boxes)
			{
				Console.WriteLine(box);
			}
			Console.ReadKey();
        }

		public static void Swap<T>(List<T> list, int first, int second)
		{
			T temp = list[first];
			list[first] = list[second];
			list[second] = temp;
		}
	}
}

