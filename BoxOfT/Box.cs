using System;
namespace BoxOfT
{
	public class Box<T>
	{
		public int Count { get; }

		private List<T> items;

		public Box()
		{
			this.items = new List<T>();
		}

		public void Add(T element)
		{
			this.items.Add(element);
		}

		public T Remove()
		{
			var lastIndex = this.items.Count - 1;

			var lastElement = items[lastIndex];

			this.items.RemoveAt(lastIndex);

			return lastElement;
		}
	}
}