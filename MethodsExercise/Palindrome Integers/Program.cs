using System;

namespace Palindrome_Integers
{
    class Program
    {
        static void Main(string[] args)
        {
            string numberAsText = Console.ReadLine();
            
            while (numberAsText.ToLower() != "end")
            {
                string reverse = Reverse(numberAsText);
                bool palidorome = numberAsText == reverse;
                Console.WriteLine(palidorome);
                numberAsText = Console.ReadLine();
            }           
        }

        public static string Reverse(string numberAsText)
        {
            char[] charArray = numberAsText.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
