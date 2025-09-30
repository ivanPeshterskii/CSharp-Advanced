using System;
namespace CustomDoublyLinkedList
{
	public class DoublyLinkedList
	{
		private class ListNode
		{
			public int Value { get; set; }

			public ListNode NextNode { get; set; }

            public ListNode PreviousNode { get; set; }

			public ListNode(int value)
			{
				this.Value = value;
			}
        }
		private ListNode head;
		private ListNode tail;

		public int Count { get; private set; }

		public void AddFirstElement(int element)
		{
			if(this.Count == 0)
			{
				this.head = this.tail = new ListNode(element);
			}
			else
			{
				var newHead = new ListNode(element);
				newHead.NextNode = this.head;
				this.head.PreviousNode = newHead;
				this.head = newHead;
			}
			this.Count++;
		}

		public int RemoveFirst(int element)
		{
			if (this.Count == 0)
			{
				throw new InvalidOperationException("The list is emoty");
			}

			var firstElement = this.head.Value;
			this.head = this.head.NextNode;
			if (this.head != null)
			{
				this.head.PreviousNode = null;
			}
			else
			{
				this.tail = null;
			}
			this.Count--;
			return firstElement;
		}

		public int RemoveLast(int element)
		{
			if(this.Count == 0)
			{
				throw new InvalidOperationException("The list is emoty");

			}

			var lastElement = this.head.Value;
			this.head = this.head.PreviousNode;
			if(this.head != null)
			{
				this.head.NextNode = null;
			}
			else
			{
				this.tail = null;
			}
			this.Count--;
			return lastElement;
		}

		public void ForEach(Action<int> action)
		{
			var current = this.head;
			while (current != null)
			{
				action(current.Value);
				current = current.NextNode;
			}
		}

		public int[] ToArray()
		{
			int[] array = new int[this.Count];

			int counter = 0;
			var currentNode = this.head;
			while (currentNode != null) 
			{
				array[counter] = currentNode.Value;
				currentNode = currentNode.NextNode;
				counter++;
			}
			return array;
		}
	}
}