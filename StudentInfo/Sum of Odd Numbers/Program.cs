using System;

namespace Sum_of_Odd_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sumOfNum = 0;

            for (int i = 1; i <= number * 2; i+=2)
            {
                sumOfNum += i;
                Console.WriteLine(i);
            }
            Console.WriteLine($"Sum: {sumOfNum}");
        }
    }
}
