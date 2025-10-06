using System;
namespace CustomLinkedList
{
	public class CustomLinkedList<T>
	{

		private class ListNode
		{
			public T Value { get; set; }

			public ListNode NextNode { get; set; }

			public ListNode PreviousNode { get; set; }

			public ListNode(T value)
			{
				this.Value = value;
			}
		}

		private ListNode head;
		private ListNode tail;

		public int Count { get; private set; }

		public void AddFirst(T element)
		{
			if (this.Count == 0)
			{
				this.head = this.tail = new ListNode(element);
			}
			else
			{
				var newhead = new ListNode(element);
				newhead.NextNode = this.head;
				this.head.PreviousNode = newhead;
				this.head = newhead;
			}
			this.Count++;
		}

		public T RemoveFirst()
		{
			if (this.Count == 0)
			{
				throw new InvalidOperationException("The list is empty");
			}

			var firstElement = this.head.Value;
			this.head = this.head.NextNode;
			if (this.head != null)
				this.head.PreviousNode = null;
			else
				this.tail = null;

			this.Count--;
			return firstElement;
		}

		public T ReamoveLast()
		{
			if (this.Count == 0)
			{
				throw new InvalidOperationException("The list is empty");
			}

			var lastElement = this.tail.Value;
			this.tail = this.tail.PreviousNode;

			if (this.tail != null)
				this.tail.NextNode = null;
			else
				this.head = null;

			this.Count--;
			return lastElement;
		}

		public void ForEach(Action<T> action)
		{
			var current = this.head;
			while (current != null)
			{
				action(current.Value);
				current = current.NextNode;
			}
		}

		public T[] ToArray()
		{
			T[] array = new T[this.Count];

			int counter = 0;
			var currentNode = this.head;
			while (currentNode!=null)
			{
				array[counter] = currentNode.Value;
				currentNode = currentNode.NextNode;
				counter++;
			}
			return array;
		}
	}
}