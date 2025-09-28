using System;
namespace CarEngineAndTires
{
	public class Car
	{
        public string Make { get; set; }

        public string Model { get; set; }

        public int Year { get; set; }

        public int FuelQuantity { get; set; }

        public int FuelConsumption { get; set; }

        public Engine Engine { get; set; }

        public Tire[] Tire { get; set; }

        public Car(string make, string model, int year, int fuelQuantity, int fuelConssumption,
            Engine engine, Tire[] tire)
        {
            this.Engine = engine;
            this.Tire = tire;
        }
    }
}

