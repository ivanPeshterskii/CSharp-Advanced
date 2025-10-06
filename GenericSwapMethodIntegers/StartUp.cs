using System;
namespace GenericSwapMethodIntegers
{
	public class StartUp
	{
		public static void Main(string[] args)
		{
			int n = int.Parse(Console.ReadLine());
			List<Box<int>> boxes = new List<Box<int>>();

			for (int i = 0; i < n; i++)
			{
				int integer = int.Parse(Console.ReadLine());
				boxes.Add(new Box<int>(integer));
			}

			var indexes = Console
				.ReadLine()
				.Split()
				.Select(int.Parse)
				.ToArray();

			int first = indexes[0];
            int second = indexes[1];

			Swap(boxes, first, second);
			foreach (var box in boxes)
			{
				Console.WriteLine(box);
			}
        }

		public static void Swap<T>(List<T> integers, int first, int second)
		{
			T temp = integers[first];
			integers[first] = integers[second];
			integers[second] = temp;
		}
	}
}

