using System;

namespace FactorialDivision
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = int.Parse(Console.ReadLine());
            int numberTwo = int.Parse(Console.ReadLine());

            FactorialDivision(numberOne, numberTwo);
        }

        private static void FactorialDivision(int numberOne, int numberTwo)
        {
            double factorialOne = 1;
            
            for (int i = 1; i <= numberOne; i++)
            {
                factorialOne *= i;
            }

            double factorialTwo = 1;

            for (int i = 1; i <= numberTwo; i++)
            {
                factorialTwo *= i;
            }

            double result = factorialOne / factorialTwo;
            Console.WriteLine($"{result:f2}");
        }
    }
}
