using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            Print(number);
        }

        private static void Print(int number)
        {
            string sign = string.Empty;
            if (number > 0)
            {
                sign = "positive";
            }
            else if (number < 0)
            {
                sign = "negative";
            }
            else
            {
                sign = "zero";
            }
            Console.WriteLine($"The number {number} is {sign}.");
        }
    }
}
