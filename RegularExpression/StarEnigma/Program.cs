using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
            int countMsges = int.Parse(Console.ReadLine());
            string input = string.Empty;
            List<string> attackedPlanets = new List<string>();
            List<string> destroyedPlanets = new List<string>();

            for (int i = 0; i < countMsges; i++)
            {
                input = Console.ReadLine();
                string decryptPattern = @"[^STARstar]";
                string decryptInput = Regex.Replace(input, decryptPattern, "");
                string decryptMsg = string.Empty;

                foreach (var letter in input)
                {
                    decryptMsg += (char)(letter - decryptInput.Length);
                }

                string pattern = @"[^@\-!:>]*@([A-z]+)[^@\-!:>]*:([\d]+)[^@\-!:>]*!([AD]{1})![^@\-!:>]*->([\d]+)[^@\-!:>]*";
                Match message = Regex.Match(decryptMsg, pattern);

                if (message.Success)
                {
                    if (message.Groups[3].Value == "A")
                    {
                        attackedPlanets.Add(message.Groups[1].Value);
                    }
                    else
                    {
                        destroyedPlanets.Add(message.Groups[1].Value);
                    }
                }
            }

            Console.WriteLine($"Attacked planets: {attackedPlanets.Count}");
            foreach (var planet in attackedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }

            Console.WriteLine($"Destroyed planets: {destroyedPlanets.Count()}");
            foreach (var planet in destroyedPlanets.OrderBy(x => x))
            {
                Console.WriteLine($"-> {planet}");
            }
        }
    }
}
