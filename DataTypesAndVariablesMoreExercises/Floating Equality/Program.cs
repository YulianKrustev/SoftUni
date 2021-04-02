using System;

namespace Floating_Equality
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double b = double.Parse(Console.ReadLine());
            double eps = 0.000001;


            Console.WriteLine(Math.Abs(Math.Round(a, 7) - Math.Round(b, 7)) < eps);
        }
    }
}
