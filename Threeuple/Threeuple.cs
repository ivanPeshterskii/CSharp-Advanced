using System;
namespace Threeuple
{
	public class Threeuple<T1, T2, T3>
	{
		public T1 FirstItem { get; set; }

        public T2 SecondItem { get; set; }

        public T3 ThirdItem { get; set; }

        public Threeuple(T1 item1, T2 item2, T3 item3)
		{
			FirstItem = item1;
			SecondItem = item2;
			ThirdItem = item3;
		}

        public override string ToString()
        {
            return $"{FirstItem} -> {SecondItem} -> {ThirdItem}";
        }
    }
}

