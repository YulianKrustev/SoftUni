using System;

namespace Water_Overflow
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double tankCapacity = 0;
            for (int input = 0; input < n; input++)
            {
                double quantityOfWater = double.Parse(Console.ReadLine());
                tankCapacity += quantityOfWater;
                while (tankCapacity > 255 && input != n - 1)
                {
                    tankCapacity -= quantityOfWater;
                    Console.WriteLine("Insufficient capacity!");
                    quantityOfWater = double.Parse(Console.ReadLine());
                    tankCapacity += quantityOfWater;
                    input++;
                }
                if (tankCapacity > 255 && input == n-1)
                {
                    tankCapacity -= quantityOfWater;
                    Console.WriteLine("Insufficient capacity!");
                    break;
                }
            }
            Console.WriteLine(tankCapacity);
        }
    }
}
