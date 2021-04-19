using System;
using System.Collections.Generic;
using System.Linq;

namespace TrafficJam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Queue<string> cars = new Queue<string>();
            string car = Console.ReadLine();
            int counter = 0;

            while (car != "end")
            {
                if (car == "green")
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (cars.Any())
                        {
                            Console.WriteLine($"{cars.Dequeue()} passed!");
                            counter++;
                        }                        
                    }
                }
                else
                {
                    cars.Enqueue(car);
                }

                car = Console.ReadLine();
            }

            Console.WriteLine($"{counter} cars passed the crossroads.");
        }
    }
}
