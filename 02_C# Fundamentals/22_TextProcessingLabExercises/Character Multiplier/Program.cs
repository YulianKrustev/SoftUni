using System;

namespace Character_Multiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            string lengthestString = string.Empty;
            string shortestString = string.Empty;

            if (input[0].Length >= input[1].Length)
            {
                lengthestString = input[0];
                shortestString = input[1];
            }
            else
            {
                lengthestString = input[1];
                shortestString = input[0];
            }

            int result = 0;

            for (int i = 0; i < lengthestString.Length; i++)
            {

                if (i < shortestString.Length)
                {
                    result += lengthestString[i] * shortestString[i];
                }
                else
                {
                    result += lengthestString[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
