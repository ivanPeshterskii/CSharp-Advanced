using System;
namespace GenericCountMethodDoubles
{
	public class Box<T> : IComparable<Box<T>> where T : IComparable<T>
	{
		public T Value { get; }

		public Box(T value)
		{
			Value = value;
		}

		public int CompareTo(Box<T> other)
		{
			return Value.CompareTo(other.Value);
		}

        public override string ToString()
        {
            return $"{typeof(T)}: {Value}";
        }
    }
}