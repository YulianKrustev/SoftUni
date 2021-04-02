using System;
using System.Text.RegularExpressions;

namespace Furniture
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex regex = new Regex(@">>([A-z]+)<<([\d]+\.*\d*)!(\d*)");
            double sum = 0;

            Console.WriteLine("Bought furniture:");

            while (input != "Purchase")
            {

                if (regex.IsMatch(input))
                {
                    Console.WriteLine(regex.Match(input).Groups[1].Value);
                    sum += double.Parse(regex.Match(input).Groups[2].Value) * int.Parse(regex.Match(input).Groups[3].Value);
                }
                
                input = Console.ReadLine();
            }

            Console.WriteLine($"Total money spend: {sum:f2}");
        }
    }
}
