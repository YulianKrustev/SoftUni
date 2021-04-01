using System;

namespace Text_Filter
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bannedwords = Console.ReadLine().Split(", ");
            string text = Console.ReadLine();

            for (int i = 0; i < bannedwords.Length; i++)
            {
                while (text.Contains(bannedwords[i]))
                {
                    text = text.Replace(bannedwords[i], new string('*', bannedwords[i].Length));
                }
            }

            Console.WriteLine(text);
        }
    }
}
