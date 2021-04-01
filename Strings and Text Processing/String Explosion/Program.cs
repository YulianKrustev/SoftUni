using System;

namespace String_Explosion
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int magicNumber = 0;

            for (int i = 0; i < input.Length; i++)
            {
                char current = input[i];

                if (current == '>')
                {
                    magicNumber += int.Parse(input[i + 1].ToString());
                    continue;
                }

                if (magicNumber > 0)
                {
                    input = input.Remove(i, 1);
                    i--;
                    magicNumber--;
                }
            }

            Console.WriteLine(input);
        }
    }
}
