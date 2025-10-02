using System;

namespace WorkshopImplementingStackAndQueue.CustomStack
{
	public class CustomStack
	{
		public const int initialCapacility = 4;

		private int[] items;

		private int count;

		public CustomStack()
		{
			this.count = 0;
			this.items = new int[initialCapacility];
		}

		public int Count
		{
			get
			{
				return this.count;
			}
		}

		public void Push(int element)
		{
			if(this.items.Length == this.count)
			{
				var nextitems = new int[this.items.Length * 2];
				for (int i = 0; i < this.items.Length; i++)
				{
					nextitems[i] = this.items[i];
				}
				this.items = nextitems;
			}
			this.items[this.count] = element;
			count++;
		}

		public int Pop()
		{
			if(this.items.Length == 0)
			{
				throw new InvalidOperationException("Empty stack!");
			}

			var lastElement = this.count - 1;
			int last = this.items[lastElement];

			this.count--;

			return last;
		}

		public int Peek()
		{
			if(this.items.Length == 0)
			{
                throw new InvalidOperationException("Empty stack!");
            }

			var element = this.items[this.count - 1];

			return element;
		}

		public void ForEach(Action<object> action)
		{
			for (int i = 0; i < this.count; i++)
			{
				action(this.items[i]);
			}
		}
	}
}

