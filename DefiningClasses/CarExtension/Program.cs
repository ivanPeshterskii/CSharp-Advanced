namespace CarManufacturer;
class Program
{
    static void Main(string[] args)
    {
        var car = new StartUp();

        car.Make = "BMW";
        car.Model = "530D E60";
        car.Year = 2005;
        car.FuelQuantity = 200;
        car.FuelConsumption = 200;
        car.Drive(2000);
        Console.WriteLine(car.WhoAmI());
    }
}

