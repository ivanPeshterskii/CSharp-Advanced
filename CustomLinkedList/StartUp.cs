using System;
namespace CustomLinkedList
{
	public class StartUp
	{
		public static void Main(string[] args)
		{
			var list = new CustomLinkedList<string>();
			list.AddFirst("C#");
			list.AddFirst("is");
			list.AddFirst("fun");

			list.ForEach(e => Console.WriteLine(e));
		}
	}
}

