using System;

namespace GenericBoxОfString
{
	public class StartUp
	{
		public static void Main(string[] args)
		{
            int n = int.Parse(Console.ReadLine());

			for (int i = 0; i < n; i++)
			{
				string command = Console.ReadLine();

				Box<string> box = new Box<string>(command);

				Console.WriteLine(box);
			}
        }
    }
}

