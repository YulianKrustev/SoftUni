using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Rage_Quit
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine().ToUpper();
            Regex regex = new Regex(@"([^\d]+)?([\d]{1,2})");
            MatchCollection matches = regex.Matches(input);
            HashSet<char> unique = new HashSet<char>();
            StringBuilder final = new StringBuilder();

            foreach (Match match in matches)
            {
                if (int.Parse(match.Groups[2].Value) == 0 || int.Parse(match.Groups[2].Value) > 20 || match.Groups[1].Value.Length > 20)
                {
                    continue;
                }
                for (int j = 0; j < match.Groups[1].Value.Length; j++)
                {
                    unique.Add(match.Groups[1].Value[j]);
                }
                for (int i = 0; i < int.Parse(match.Groups[2].Value); i++)
                {
                    final.Append(match.Groups[1].Value);
                }
            }

            Console.WriteLine($"Unique symbols used: {unique.Count}");
            Console.WriteLine(final.ToString());
        }
    }
}
