using System;
using System.Collections.Generic;

namespace Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int pumps = int.Parse(Console.ReadLine());
            Queue<string> truckTour = new Queue<string>();
            int startIndex = 0;
            int liters = 0;

            for (int i = 0; i < pumps; i++)
            {
                truckTour.Enqueue(Console.ReadLine());
            }

            for (int i = 0, j=0; i < pumps; i++, j++)
            {
                string tokens = truckTour.Dequeue();
                string[] current = tokens.Split();
                liters += int.Parse(current[0]) - int.Parse(current[1]);

                if (liters < 0)
                {
                    startIndex = j + 1;
                    liters = 0;
                }

                truckTour.Enqueue(tokens);
            }

            Console.WriteLine(startIndex);

        }
    }
}
