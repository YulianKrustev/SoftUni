using System;

namespace CleverLily
{
    class Program
    {
        static void Main(string[] args)
        {
            int years = int.Parse(Console.ReadLine());
            double machinePrice = double.Parse(Console.ReadLine());
            double toysPrice = double.Parse(Console.ReadLine());
            double safeMoney = 0;
            int toysCount = 0;
            int j = 1;

            for (int i = 1; i <= years; i++)
            {
                
                if (i % 2 == 0)
                {
                    safeMoney += (10 * j++) - 1;
                    
                }
                else
                {
                    toysCount++;
                }
            }
            double safeSum = (toysCount * toysPrice) + safeMoney - machinePrice;

            if (safeSum >= 0)
            {
                Console.WriteLine($"Yes! {safeSum:f2}");
            }
            else
            {
                Console.WriteLine($"No! {-1 * safeSum:f2}");
            }
        }
    }
}
