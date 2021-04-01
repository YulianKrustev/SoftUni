using System;

namespace Recursive_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int[] fibonacci = new int[number];

            for (int i = 0; i < number; i++)
            {
                if ((i == 0) || (i == 1))
                {
                    fibonacci[i] = 1;
                }
                else
                {
                    fibonacci[i] = ((fibonacci[i - 1]) + (fibonacci[i - 2]));
                }
            }
            Console.WriteLine(fibonacci[number - 1]);
            
        }
    }
}
