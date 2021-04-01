using System;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int maxNumber = int.MinValue;
            int sum = 0;

            for (int i = 1; i <= inputNumber; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                sum += currentNumber; 
                if (currentNumber > maxNumber)
                {
                    maxNumber = currentNumber;
                }
            }

            if (sum - maxNumber == maxNumber)
            {
                Console.WriteLine($"Yes\nSum = {maxNumber}");
            }
            else
            {
                Console.WriteLine($"No\nDiff = {Math.Abs(maxNumber - (sum - maxNumber))}");
            }
        }
    }
}
