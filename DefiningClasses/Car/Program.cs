namespace CarManufacturer
{
    public class StartUp
    {
        static void Main()
        {
            var car = new Car();

            car.Make = "BMW";
            car.Model = "530D E60";
            car.Year = 2005;

            Console.WriteLine($"Make: {car.Make}\nModel: {car.Model}\nYear: {car.Year}");     
        }
    }
}
