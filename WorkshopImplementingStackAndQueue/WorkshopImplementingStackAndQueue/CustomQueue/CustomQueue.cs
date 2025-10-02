using System;
namespace WorkshopImplementingStackAndQueue.CustomQueue
{
	public class CustomQueue
	{
		private const int initialCapaciity = 4;

        private const int firstElementIndex = 0;

        private int[] items;

		private int count;

		public int Count => count;

		public CustomQueue()
		{
			this.count = 0;
			this.items = new int[initialCapaciity];
		}

		public void Enqueue(int item)
		{
			if(items.Length == count)
			{
				IncreaseSize();
			}

			items[count] = item;
			count++;
		}

		private void IncreaseSize()
		{
			int[] array = new int[items.Length * 2];
			items.CopyTo(array, 0);
			items = array;
		}

		private void IsEmpty()
		{
			if (this.items.Length == 0)
			{
				throw new InvalidOperationException("Empty Queue!");
			}
		}

		private void SwitchElements()
		{
			items[firstElementIndex] = default;

			for (int i = 1; i < items.Length; i++)
			{
				items[i - 1] = items[i];
			}
			items[items.Length - 1] = default;
		}

		public void Dequeue()
		{
			IsEmpty();
			count--;
			var firstElement = items[firstElementIndex];
			SwitchElements();
		}

		public int Peek()
		{
			IsEmpty();

			var element = items[count - 1];

			return element;
		}

		public void Clear()
		{
			IsEmpty();

			this.count = 0;

			this.items = new int[initialCapaciity];

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

