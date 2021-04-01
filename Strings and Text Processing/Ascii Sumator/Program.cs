using System;

namespace Ascii_Sumator
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstSymbol = char.Parse(Console.ReadLine());
            int secondSymbol = char.Parse(Console.ReadLine());
            string input = Console.ReadLine();
            int result = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] > firstSymbol && input[i] < secondSymbol)
                {
                    result += input[i];
                }
            }

            Console.WriteLine(result);

        }
    }
}
