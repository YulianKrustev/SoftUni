using System;

namespace Math_Power
{
    class Program
    {
        static void Main(string[] args)
        {
            double numberToPower = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());

            double result = Math_Power(numberToPower, power);
            Console.WriteLine(result);
        }

        private static double Math_Power(double numberToPower, int power)
        {
            return Math.Pow(numberToPower, power);
        }
    }
}
