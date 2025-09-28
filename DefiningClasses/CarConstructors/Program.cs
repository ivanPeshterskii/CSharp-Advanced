namespace CarConstructors;
class Program
{
    static void Main(string[] args)
    {
        string make = Console.ReadLine();
        string model = Console.ReadLine();
        int year = int.Parse(Console.ReadLine());
        int fuelQuantity = int.Parse(Console.ReadLine());
        int fuelConsumption = int.Parse(Console.ReadLine());

        Car firstCar = new Car(make, model, year);
        Car secondCar = new Car(make, model, year, fuelQuantity, fuelConsumption);

    }
}

