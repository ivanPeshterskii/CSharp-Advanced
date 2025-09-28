using System;
namespace CarEngineAndTires
{
	public class Engine
	{
		public int HorsePower { get; set; }

		public double CubicCapacility { get; set; }

		public Engine(int horsePower, double cubicCapacility)
		{
			this.HorsePower = horsePower;
			this.CubicCapacility = cubicCapacility;
		}
	}
}

