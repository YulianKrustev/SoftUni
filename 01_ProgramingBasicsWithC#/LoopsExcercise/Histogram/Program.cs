using System;

namespace Histogram
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int currentNumber = 0;
            double under200 = 0;
            double under400 = 0;
            double under600 = 0;
            double under800 = 0;
            double above800 = 0;

            for (int i = 1; i <= inputNumber; i++)
            {
                currentNumber = int.Parse(Console.ReadLine());

                if (currentNumber < 200)
                {
                    under200++;
                } 
                else if (currentNumber >= 200 && currentNumber < 400)
                {
                    under400++;
                }
                else if (currentNumber >= 400 && currentNumber < 600)
                {
                    under600++;
                }
                else if (currentNumber >= 600 && currentNumber < 800)
                {
                    under800++;
                }
                else
                {
                    above800++;
                }
            }
            double p1 = (under200 / inputNumber) * 100;
            double p2 = (under400 / inputNumber) * 100;
            double p3 = (under600 / inputNumber) * 100;
            double p4 = (under800 / inputNumber) * 100;
            double p5 = (above800 / inputNumber) * 100;
            if (under200 == 0)
            {
                Console.WriteLine($"{0:f2}%");
            }
            else
            {
                Console.WriteLine($"{p1:f2}%");
            }
            if (under400 == 0)
            {
                Console.WriteLine($"{0:f2}%");
            }
            else
            {
                Console.WriteLine($"{p2:f2}%");
            }
            if (under600 == 0)
            {
                Console.WriteLine($"{0:f2}%");
            }
            else
            {
                Console.WriteLine($"{p3:f2}%");
            }
            if (under800 == 0)
            {
                Console.WriteLine($"{0:f2}%");
            }
            else
            {
                Console.WriteLine($"{p4:f2}%");
            }
            if (above800 == 0)
            {
                Console.WriteLine($"{0:f2}%");
            }
            else
            {
                Console.WriteLine($"{p5:f2}%");
            }
            
        }
    }
}
