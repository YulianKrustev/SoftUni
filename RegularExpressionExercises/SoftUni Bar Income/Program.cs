using System;
using System.Text.RegularExpressions;

namespace SoftUni_Bar_Income
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"%([A-Z][a-z]+)%[^|$%.]*<(\w+)>[^|$%.]*\|(\d+)\|[^|$%.]*?(\d+\.?\d*)\$";
            double totalIncome = 0;

            while (input != "end of shift")
            {
                if (Regex.IsMatch(input, pattern))
                {
                    Match token = Regex.Match(input, pattern);
                    string name = token.Groups[1].Value;
                    string product = token.Groups[2].Value;
                    string count = token.Groups[3].Value;
                    string price = token.Groups[4].Value;
                    totalIncome += int.Parse(count) * double.Parse(price);

                    Console.WriteLine($"{name}: {product} - {int.Parse(count) * double.Parse(price):f2}");
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total income: {totalIncome:f2}");
        }
    }
}
