using System;

namespace Balanced_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfInputs = int.Parse(Console.ReadLine());
            int balanced = 0;
            int countOpenBracket = 0;
            int countCloseBracket = 0;

            for (int i = 0; i < numberOfInputs; i++)
            {
                string currentInput = Console.ReadLine();
                if (currentInput == "(")
                {
                    countOpenBracket++;
                }
                if (countOpenBracket > countCloseBracket)
                {
                    if (currentInput == ")")
                    {
                        countCloseBracket++;
                        balanced++;
                    }
                }
            }
            if (balanced == countOpenBracket && balanced == countCloseBracket)
            {
                Console.WriteLine("BALANCED");
            }
            else
            {
                Console.WriteLine("UNBALANCED");
            }
        }
    }
}
