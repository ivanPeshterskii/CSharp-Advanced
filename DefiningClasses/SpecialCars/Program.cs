using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
        static void Main()
        {
            List<Tire[]> tireSets = new List<Tire[]>();

            string input;
            while ((input = Console.ReadLine()) != "No more tires")
            {
                double[] tireData = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                         .Select(double.Parse)
                                         .ToArray();

                Tire[] tires = new Tire[4];
                for (int i = 0; i < 4; i++)
                {
                    int year = (int)tireData[i * 2];
                    double pressure = tireData[i * 2 + 1];
                    tires[i] = new Tire { Year = year, Pressure = pressure };
                }
                tireSets.Add(tires);
            }

            List<Engine> engines = new List<Engine>();
            while ((input = Console.ReadLine()) != "Engines done")
            {
                double[] engineData = input.Split(' ', StringSplitOptions.RemoveEmptyEntries)
                                           .Select(double.Parse)
                                           .ToArray();

                int horsePower = (int)engineData[0];
                double cubicCapacity = engineData[1];

                engines.Add(new Engine { HorsePower = horsePower, CubicCapacity = cubicCapacity });
            }


            List<Car> cars = new List<Car>();
            while ((input = Console.ReadLine()) != "Show special")
            {
                string[] carData = input.Split(' ', StringSplitOptions.RemoveEmptyEntries);

                string make = carData[0];
                string model = carData[1];
                int year = int.Parse(carData[2]);
                double fuelQuantity = double.Parse(carData[3]);
                double fuelConsumption = double.Parse(carData[4]);
                int engineIndex = int.Parse(carData[5]);
                int tireIndex = int.Parse(carData[6]);

                Car car = new Car
                {
                    Make = make,
                    Model = model,
                    Year = year,
                    FuelQuantity = fuelQuantity,
                    FuelConsumption = fuelConsumption,
                    Engine = engines[engineIndex],
                    Tires = tireSets[tireIndex]
                };

                cars.Add(car);
            }


            var specialCars = cars.Where(c =>
                c.Year >= 2017 &&
                c.Engine.HorsePower > 330 &&
                c.Tires.Sum(t => t.Pressure) >= 9 &&
                c.Tires.Sum(t => t.Pressure) <= 10
            );


            foreach (var car in specialCars)
            {
                car.FuelQuantity -= car.FuelConsumption * 20;

                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"HorsePowers: {car.Engine.HorsePower}");
                Console.WriteLine($"FuelQuantity: {car.FuelQuantity}");
            }
        }
}


class Tire
{
    public int Year { get; set; }

    public double Pressure { get; set; }
}

class Engine
{
    public int HorsePower { get; set;}

    public double CubicCapacity { get; set; }
}

class Car
{
    public string Make { get; set; }

    public string Model { get; set; }

    public int Year { get; set; }

    public double FuelQuantity { get; set; }

    public double FuelConsumption { get; set; }

    public Tire[] Tires { get; set; }

    public Engine Engine { get; set; }
}