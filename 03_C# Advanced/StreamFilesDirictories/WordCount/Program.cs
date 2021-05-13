using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> results = new Dictionary<string, int>();
            string[] words = File.ReadAllText("words.txt")
                                 .ToLower()
                                 .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            foreach (var word in words)
            {
                if (results.ContainsKey(word) == false)
                {
                    results.Add(word, 0);
                }
            }

            string text = File.ReadAllText("text.txt").ToLower();

            string[] filtredText = Regex.Matches(text, @"[a-zA-Z]+")
                                   .Cast<Match>()
                                   .Select(m => m.Value)
                                   .ToArray();        

            foreach (var item in filtredText)
            {
                if (results.ContainsKey(item))
                {
                    results[item]++;
                }
            }

            foreach (var word in results.OrderByDescending(x=> x.Value))
            {
                using (StreamWriter sw = new StreamWriter("output.txt", true))
                {
                    sw.WriteLine($"{word.Key} - {word.Value}");
                }
            }
        }
    }
}
