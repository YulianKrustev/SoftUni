using System;

namespace DivideWithoutRemainder
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            double p1 = 0;
            double p2 = 0;
            double p3 = 0;

            for (int i = 1; i <= input; i++)
            {
                int currentN = int.Parse(Console.ReadLine());

                if (currentN % 2 == 0)
                {
                    p1++;
                } 
                if (currentN % 3 == 0)
                {
                    p2++;
                }
                if (currentN % 4 == 0)
                {
                    p3++;
                }
            }
            double p1final = p1 / input * 100;
            double p2final = p2 / input * 100;
            double p3final = p3 / input * 100;

            Console.WriteLine($"{p1final:f2}%");
            Console.WriteLine($"{p2final:f2}%");
            Console.WriteLine($"{p3final:f2}%");
        }
    }
}
