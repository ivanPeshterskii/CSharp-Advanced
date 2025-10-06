using System;
namespace Tuple
{
	public class Tuple<T1, T2>
	{
		public T1 FirstItem { get; set; }

        public T2 SecondItem { get; set; }

        public Tuple(T1 item1, T2 item2)
		{
            FirstItem = item1;
            SecondItem = item2;
		}

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem}";
        }
    }
}

