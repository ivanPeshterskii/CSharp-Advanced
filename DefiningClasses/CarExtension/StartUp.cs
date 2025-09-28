using System;
namespace CarManufacturer
{
	public class StartUp
	{
		public string Make { get; set; }

		public string Model { get; set; }

		public int Year { get; set; }

		public double FuelQuantity { get; set; }

        public double FuelConsumption { get; set; }

		public void Drive(double distance)
		{
			double fuelQuantity = FuelQuantity;
			double carFuelConsumption = FuelConsumption;

			double resutlt = (fuelQuantity - distance) * carFuelConsumption;

			if (resutlt < 0)
			{
				Console.WriteLine("Not enough fuel to perform this trip!");
			}
		}

		public string WhoAmI()
		{
			return $@"
Make: {this.Make}
Model: {this.Model}
Year: {this.Year}
Fuel: {this.FuelQuantity:F2}";
		}
    }
}

