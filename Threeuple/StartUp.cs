using System;
namespace Threeuple
{
	public class StartUp
	{
		public static void Main(string[] args)
		{
			string[] firstInput = Console
				.ReadLine()
				.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			string fullName = firstInput[0] + " " + firstInput[1];
			string address = firstInput[2];
            string town = string.Join(" ", firstInput, 3, firstInput.Length - 3);
            var threeuple1 = new Threeuple<string, string, string>(fullName, address, town);

			string[] secondInput = Console
				.ReadLine()
				.Split(' ', StringSplitOptions.RemoveEmptyEntries);
			string name = secondInput[0];
			int litersOfbeer = int.Parse(secondInput[1]);
			bool isDrunk = secondInput[2].ToLower() == "drunk";
			var threeuple2 = new Threeuple<string, int, bool>(name, litersOfbeer, isDrunk);

            string[] thirdInput = Console
                .ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string nam = thirdInput[0];
            double bankBalance = double.Parse(thirdInput[1]);
            string nameBank = thirdInput[2];
            var threeuple3 = new Threeuple<string, double, string>(nam, bankBalance, nameBank);

			Console.WriteLine(threeuple1);
            Console.WriteLine(threeuple2);
            Console.WriteLine(threeuple3);
        }
	}
}