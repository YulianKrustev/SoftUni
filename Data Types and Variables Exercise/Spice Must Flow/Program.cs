using System;

namespace Spice_Must_Flow
{
    class Program
    {
        static void Main(string[] args)
        {
            int yield = int.Parse(Console.ReadLine());
            int totalAmount = 0;
            int daysCounter = 0;
            
            while (yield >= 100)
            {
                daysCounter++;
                totalAmount += yield - 26;
                yield -= 10;
            }
            if (totalAmount != 0)
            {
                totalAmount -= 26;
                Console.WriteLine($"{daysCounter}\n{totalAmount}");
            }
            else
            {
                Console.WriteLine($"{daysCounter}\n{totalAmount}");
            }
        }
    }
}
