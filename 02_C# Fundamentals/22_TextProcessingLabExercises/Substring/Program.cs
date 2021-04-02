using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string bannedWord = Console.ReadLine().ToLower();
            string text = Console.ReadLine().ToLower();


            while (text.IndexOf(bannedWord) > -1)
            {
                text = text.Replace(bannedWord, string.Empty);
            }
            Console.WriteLine(text);
        }
    }
}
