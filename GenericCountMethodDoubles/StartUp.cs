using System;
namespace GenericCountMethodDoubles
{
	public class StartUp
	{
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Box<double>> boxes = new List<Box<double>>();

            for (int i = 0; i < n; i++)
            {
                double number = double.Parse(Console.ReadLine());
                boxes.Add(new Box<double>(number));
            }

            double valueToCompare = double.Parse(Console.ReadLine());
            Box<double> boxToCampare = new Box<double>(valueToCompare);

            int count = CountGreaterThan(boxes, boxToCampare);
            Console.WriteLine(count);
            Console.ReadKey();
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