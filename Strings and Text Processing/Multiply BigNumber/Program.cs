using System;

namespace Multiply_BigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int multiplaer = int.Parse(Console.ReadLine());

            int restNumber = 0;
            string final = string.Empty;

            if (multiplaer == 0)
            {
                Console.WriteLine("0");
                return;
            }

            for (int i = bigNumber.Length - 1; i >= 0; i--)
            {
                int currentDigit = int.Parse(bigNumber[i].ToString());
                int result = currentDigit * multiplaer;
                int addNumber = (restNumber + result) % 10;

                final = final.Insert(0, addNumber.ToString());
                restNumber = (restNumber + result - addNumber) / 10;
            }
            if (restNumber > 0)
            {
                final = final.Insert(0, restNumber.ToString());
            }
            Console.WriteLine(final);
        }
    }
}
