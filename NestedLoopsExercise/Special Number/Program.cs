using System;

namespace Special_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    for (int e = 1; e < 10; e++)
                    {
                        for (int k = 1; k < 10; k++)
                        {
                            if (number % i == 0 && number % j == 0 && number % e == 0 && number % k == 0)
                            {
                                Console.Write($"{i}{j}{e}{k} ");
                            }
                        }
                    }
                }
               
            }

        }
    }
}
