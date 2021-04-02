using System;

namespace EvenOrOdd
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumbers = int.Parse(Console.ReadLine());
            int even = 0;
            int odd = 0;

            for (int i = 0; i < inputNumbers; i++)
            {
                int currentNumber = int.Parse(Console.ReadLine());

                if (i % 2 == 0)
                {
                    even += currentNumber;
                }
                else
                {
                    odd += currentNumber;
                }
            }

            if (even == odd)
            {
                Console.WriteLine("Yes\n" + "Sum = " + even);
            }
            else
            {
                if (even > odd)
                {
                    Console.WriteLine("No\n" + "Diff = " + (even - odd));
                }
                else
                {
                    Console.WriteLine("No\n" + "Diff = " + (odd - even));
                }
            }
        }
    }
}
