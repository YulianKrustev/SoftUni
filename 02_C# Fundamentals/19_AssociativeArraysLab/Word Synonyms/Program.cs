using System;
using System.Collections.Generic;

namespace Word_Synonyms
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfWords = int.Parse(Console.ReadLine());
            Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

            for (int i = 0; i < numberOfWords; i++)
            {
                string currentWord = Console.ReadLine();
                string currentSynonym = Console.ReadLine();

                if (dictionary.ContainsKey(currentWord))
                {
                    dictionary[currentWord].Add(currentSynonym);
                }
                else
                {
                    dictionary.Add(currentWord, new List<string> { currentSynonym });
                }
            }

            foreach (var word in dictionary)
            {
                Console.WriteLine($"{word.Key} - {string.Join(", ", word.Value)}");
            }
        }
    }
}
