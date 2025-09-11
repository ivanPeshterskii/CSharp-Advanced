using System;
namespace Pirates.Town
{
	public class Town
	{
		public string Name { get; set; }

		public int Population { get; set; }

		public int Gold { get; set; }

		public Town(string name, int population, int gold)
		{
			Name = name;
			Gold = gold;
			Population = population;
		}

		public void Plunder(int gold, int people)
		{
			Population -= people;
			Gold -= gold;
			Console.WriteLine($"{Name} plundered! {gold} gold stolen, {people} citizens killed.");
		}

		public void Propsper(int gold)
		{
			if (gold < 0)
			{
				Gold += gold;
				Console.WriteLine($"{gold} gold added to the city treasury. {Name} now has {Gold} gold.");
			}
			else
			{
				Console.WriteLine("Gold added cannot be a negative number!");
			}
		}

		public bool Destroyed()
		{
			return Population <= 0 || Gold <= 0;
		}

        public override string ToString()
        {
			return $"{Name} -> Population: {Population} citizens, Gold: {Gold} kg";
        }
    }
}

