using System;

namespace TopNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i <= number; i++)
            {
                bool isDivisibleTo8 = CheckIsDivisbleTo8(i);
                bool isHasOdd = CheckNuberHasOddDigit(i);

                if (isDivisibleTo8 && isHasOdd)
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool CheckNuberHasOddDigit(int i)
        {
            int currentNum = 0;
            bool isFound = false;

            while (i > 0)
            {
                currentNum = i % 10;
                if (currentNum % 2 != 0)
                {
                    isFound = true;
                    break;
                }
                else
                {
                    i /= 10;
                }
            }
            return isFound;
        }

        private static bool CheckIsDivisbleTo8(int i)
        {
            int sumOfDigits = 0;

            while (i > 0)
            {
                sumOfDigits += i % 10;
                i = i / 10;
            }

            if (sumOfDigits % 8 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
