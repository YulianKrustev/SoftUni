using System;
using System.Text.RegularExpressions;

namespace FancyBarcodes
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfBarcodes = int.Parse(Console.ReadLine());
            Regex barcodeValidator = new Regex(@"([@][#]+)([A-Z][A-Za-z0-9]{4,}[A-Z]{1})([@][#]+)");
            Regex digitFinder = new Regex(@"[\d]");
            string barcode = string.Empty;
            string productGroup = "00";
            

            for (int i = 0; i < numberOfBarcodes; i++)
            {
                barcode = Console.ReadLine();

                if (barcodeValidator.Match(barcode).Success)
                {
                    if (digitFinder.Match(barcode).Success)
                    {
                        MatchCollection digits = digitFinder.Matches(barcode);
                        Console.WriteLine($"Product group: {string.Join("", digits)}");
                    }
                    else
                    {
                        Console.WriteLine("Product group: 00");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }

            }
        }
    }
}
