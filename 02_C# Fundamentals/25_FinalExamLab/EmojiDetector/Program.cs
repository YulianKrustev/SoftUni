using System;
using System.Numerics;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex digits = new Regex(@"\d");
            MatchCollection digitsInText = digits.Matches(input);
            BigInteger coolNumber = 1;

            foreach (Match number in digitsInText)
            {
                coolNumber *= int.Parse(number.ToString());
            }

            Regex emojiFinder = new Regex(@"([*][*]|[\:][\:])([A-Z][a-z]{2,})\1");
            MatchCollection emojisInText = emojiFinder.Matches(input);

            Console.WriteLine($"Cool threshold: {coolNumber}");
            Console.WriteLine($"{emojisInText.Count} emojis found in the text. The cool ones are:");

            foreach (Match emoji in emojisInText)
            {
                int points = 0;

                foreach (var symbol in emoji.Groups[2].Value)
                {
                    points += char.Parse(symbol.ToString());
                }

                if (points > coolNumber)
                {
                    Console.WriteLine(emoji);
                }
            }
        }
    }
}
