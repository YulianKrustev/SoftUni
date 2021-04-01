using System;

namespace Multiply_Evens_by_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Math.Abs(int.Parse(Console.ReadLine()));
            int sumOfEvenNums = GetSumOfEvenDigits(number);
            int sumOfOddNums = GetSumOfOddDigits(number);
            int result = GetMultipleOfEvenAndOdd(sumOfOddNums, sumOfEvenNums);
            Console.WriteLine(result);

        }

        private static int GetMultipleOfEvenAndOdd(int sumOfOddNums, int sumOfEvenNums)
        {
            int result = sumOfEvenNums * sumOfOddNums;

            return result;
        }

        private static int GetSumOfOddDigits(int number)
        {
            int sumOfOddDigits = 0;

            while (number > 0)
            {
                int digit = number % 10;

                if (digit % 2 != 0)
                {
                    sumOfOddDigits += digit;
                }

                number = number / 10;
            }

            return sumOfOddDigits;
        }

        private static int GetSumOfEvenDigits(int number)
        {
            int sumOfEvenDigits = 0;

            while (number > 0)
            {
                int digit = number % 10;

                if (digit % 2 == 0)
                {
                    sumOfEvenDigits += digit;
                }
            
                number = number / 10;
            }

            return sumOfEvenDigits;
        }
    }
}
