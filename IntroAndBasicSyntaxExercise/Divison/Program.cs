using System;

namespace Divison
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            string divisible = string.Empty;

            if (number % 10 == 0)
            {
                divisible = "The number is divisible by 10";
            }
            else if (number % 7 == 0)
            {
                divisible = "The number is divisible by 7";
            }
            else if (number % 6 == 0)
            {
                divisible = "The number is divisible by 6";
            }
            else if (number % 3 == 0)
            {
                divisible = "The number is divisible by 3";
            }
            else if (number % 2 == 0)
            {
                divisible = "The number is divisible by 2";
            }
            else
            {
                divisible = "Not divisible";
            }
            Console.WriteLine(divisible);
        }
    }
}
