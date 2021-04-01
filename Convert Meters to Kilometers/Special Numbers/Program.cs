using System;

namespace Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                int currentNumber = i;
                int sumOfDigit = 0;

                while (currentNumber > 0)
                {                   
                    sumOfDigit += currentNumber % 10;
                    currentNumber /= 10;
                }
                if (sumOfDigit == 5 || sumOfDigit == 7 || sumOfDigit == 11)
                {
                    Console.WriteLine($"{i} -> True");
                }
                else
                {
                    Console.WriteLine($"{i} -> False");
                }
            }
        }
    }
}
