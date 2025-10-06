using System;
namespace GenericCountMethodStrings
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

            string valueToCampare = Console.ReadLine();
            Box<string> boxToCampare = new Box<string>(valueToCampare);

            int count = CountGreaterThan(boxes, boxToCampare);
            Console.WriteLine(count);
        }

        public static int CountGreaterThan<T>(List<Box<T>> list, Box<T> element)
            where T : IComparable<T>
        {
            int count = 0;
            foreach (var item in list)
            {
                if (item.CompareTo(element) > 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}