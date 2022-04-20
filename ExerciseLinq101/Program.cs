using System;
using System.Linq;

namespace ExerciseLinq101
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample_Aggregate_Lambda_Seed();
        }

        private static void Sample_Aggregate_Lambda_Simple()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5 };

            var result = numbers.Aggregate((a, b) => a * b);

            Console.WriteLine("Aggregated numbers by multiplication:");
            Console.WriteLine(result);
        }

        private static void Sample_Aggregate_Lambda_Seed()
        {
            var numbers = new int[] { 1, 2, 3 };

            var result = numbers.Aggregate(10, (a, b) => a + b);

            Console.WriteLine("Aggregated numbers by addition with a seed of 10:");
            Console.WriteLine(result);
        }
    }
}
