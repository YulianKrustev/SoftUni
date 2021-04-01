using System;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int countVowel = VowelsCount(input);
            Console.WriteLine(countVowel);
        }

        private static int VowelsCount(string input)
        {
            int vowelCounter = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'a' ||
                    input[i] == 'A' ||
                    input[i] == 'e' ||
                    input[i] == 'E' ||
                    input[i] == 'o' ||
                    input[i] == 'O' ||
                    input[i] == 'i' ||
                    input[i] == 'I' ||
                    input[i] == 'u' ||
                    input[i] == 'U')
                {
                    vowelCounter++;
                }

            }
            return vowelCounter;
        }
    }
}
