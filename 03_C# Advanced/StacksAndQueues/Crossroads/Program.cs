using System;
using System.Collections.Generic;
using System.Linq;

namespace Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightDuration = int.Parse(Console.ReadLine());
            int freeWindowDuration = int.Parse(Console.ReadLine());
            string car = Console.ReadLine();
            Queue<string> cars = new Queue<string>();
            int counter = 0;


            while (car != "END")
            {
                if (car == "green")
                {
                    
                    int timeLeft = greenLightDuration;

                    while (timeLeft > 0 && cars.Any())
                    {
                        string current = cars.Peek();
                        int needTime = current.Length;       

                        if (timeLeft > 0)
                        {
                            cars.Dequeue();
                            timeLeft -= needTime;

                            if (timeLeft < 0)
                            {
                                timeLeft += freeWindowDuration;

                                if (timeLeft < 0)
                                {
                                    Console.WriteLine("A crash happened!");
                                    Console.WriteLine($"{current} was hit at {current[current.Length + timeLeft]}.");
                                    return;
                                }
                                timeLeft = -1;
                            }
                        
                        }
                        counter++;
                    }
                }
                else
                {
                    cars.Enqueue(car);
                }

                car = Console.ReadLine();
            }

            Console.WriteLine("Everyone is safe.");
            Console.WriteLine($"{counter} total cars passed the crossroads.");
        }
    }
}
