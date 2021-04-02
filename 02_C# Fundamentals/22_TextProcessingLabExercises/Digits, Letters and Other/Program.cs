using System;
using System.Text;

namespace Digits__Letters_and_Other
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string isDigit = string.Empty;
            string isLetter = string.Empty;
            string isSymbol = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (Char.IsDigit(input[i]))
                {
                    isDigit += input[i];
                }
                else if (Char.IsLetter(input[i]))
                {
                    isLetter += input[i];
                }
                else 
                {
                    isSymbol += input[i];
                }
            }
            Console.WriteLine(isDigit);
            Console.WriteLine(isLetter);
            Console.WriteLine(isSymbol);
        }
    }
}
