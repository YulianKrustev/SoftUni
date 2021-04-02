using System;

namespace OddEvenPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            double oddSum = 0;
            double oddMin = double.MaxValue;
            double oddMax = double.MinValue;
            double evenSum = 0;
            double evenMin = double.MaxValue;
            double evenMax = double.MinValue;
            double evenCurrentNumber = 0;
            double oddCurrentNumber = 0;

            for (int i = 1; i <= input; i++)
            {
                if (i % 2 == 0)
                {
                    evenCurrentNumber = double.Parse(Console.ReadLine());
                    evenSum += evenCurrentNumber;
                    if (evenCurrentNumber < evenMin)
                    {
                        evenMin = evenCurrentNumber;
                    }
                    if (evenCurrentNumber > evenMax)
                    {
                        evenMax = evenCurrentNumber;
                    }
                }
                else
                {
                    oddCurrentNumber = double.Parse(Console.ReadLine());
                    oddSum += oddCurrentNumber;
                    if (oddCurrentNumber < oddMin)
                    {
                        oddMin = oddCurrentNumber;
                    }
                    if (oddCurrentNumber > oddMax)
                    {
                        oddMax = oddCurrentNumber;
                    }
                }
            }

            Console.WriteLine($"OddSum={oddSum:f2},");
            if (oddMin == double.MaxValue)
            {
                Console.WriteLine($"OddMin=No,");
            }
            else
            {
                Console.WriteLine($"OddMin={oddMin:f2},");
            }
            if (oddMax == double.MinValue)
            {
                Console.WriteLine($"OddMax=No,");
            }
            else
            {
                Console.WriteLine($"OddMax={oddMax:f2},");
            }
            Console.WriteLine($"EvenSum={evenSum:f2},");
            if (evenMin == double.MaxValue)
            {
                Console.WriteLine($"EvenMin=No,");
            }
            else
            {
                Console.WriteLine($"EvenMin={evenMin:f2},");
            }
            if (evenMax == double.MinValue)
            {
                Console.WriteLine($"EvenMax=No");
            }
            else
            {
                Console.WriteLine($"EvenMax={evenMax:f2}");
            }
        }
    }
}
