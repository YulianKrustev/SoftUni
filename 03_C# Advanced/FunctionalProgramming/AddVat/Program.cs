using System;
using System.Linq;

namespace AddVat
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal[] addVat = Console.ReadLine().Split(", ", StringSplitOptions.RemoveEmptyEntries).Select(x => decimal.Parse(x) * 1.2M).ToArray();

            foreach (var number in addVat)
            {
                Console.WriteLine($"{number:f2}");
            }
        }
    }
}
