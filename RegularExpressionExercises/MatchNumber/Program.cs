using System;
using System.Text.RegularExpressions;

namespace MatchNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string phoneString = Console.ReadLine();
            Regex validPhonesPatter = new Regex(@"\b(?<day>\d{2})([/.-])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b");

            Console.WriteLine(string.Join(", ", validPhonesPatter.Matches(phoneString)));
        }
    }
}
