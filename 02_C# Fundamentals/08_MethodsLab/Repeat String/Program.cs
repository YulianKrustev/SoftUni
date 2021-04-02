using System;

namespace Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int repatCount = int.Parse(Console.ReadLine());

            Console.WriteLine(Repeat_String(input, repatCount));
        }

        private static string Repeat_String(string input, int repatCount)
        {
            string result = string.Empty;

            for (int i = 0; i < repatCount; i++)
            {
                result += input;
            }

            return result;
        }
    }
}
