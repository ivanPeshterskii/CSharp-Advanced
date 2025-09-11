using System;
using System.Text.RegularExpressions;

namespace FancyBarcodes;
class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        string pattern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";

        for (int i = 0; i < n; i++)
        {
            string barcode = Console.ReadLine();

            if(Regex.IsMatch(barcode, pattern))
            {
                string inner = Regex.Match(barcode, @"[A-Z][A-Za-z0-9]{4,}[A-Z]").Value;
                MatchCollection digits = Regex.Matches(barcode, @"\d");

                string productGroup = digits.Count > 0 ? string.Concat(digits) : "00";

                Console.WriteLine($"Product group: {productGroup}");
            }
            else
            {
                Console.WriteLine("Invalid barcode");
            }
            
        }
        Console.ReadKey();
    }
}

