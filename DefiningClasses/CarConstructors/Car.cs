using System;
namespace CarConstructors
{
	public class Car
	{
		public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int FuelQuantity { get; set; }

        public int FuelConsumption { get; set; }

        public Car(string make, string model, int year)
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, int fuelQuantity, int fuelConssumption)
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConssumption;
        }
    }
}

