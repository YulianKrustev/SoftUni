using System;

namespace Caesar_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string encrypted = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                encrypted += (char)(input[i] + 3);
            }

            Console.WriteLine(encrypted);
        }
    }
}
