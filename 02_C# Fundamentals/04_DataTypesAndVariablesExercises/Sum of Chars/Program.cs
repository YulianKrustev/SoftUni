using System;

namespace Sum_of_Chars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int sumOfChar = 0;
            for (int i = 0; i < n; i++)
            {
                char letter = Console.ReadLine()[0];
                sumOfChar += letter;
            }
            Console.WriteLine($"The sum equals: {sumOfChar}");
        }
    }
}
