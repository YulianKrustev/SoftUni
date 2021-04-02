using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Treasure_Finder
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] key = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string forDecrypt = Console.ReadLine();
            StringBuilder result = new StringBuilder();
            List<string> final = new List<string>();

            while (forDecrypt != "find")
            {
                for (int i = 0, j = 0; i < forDecrypt.Length; i++, j++)
                {
                    result = result.Append((char)(forDecrypt[i] - key[j]));

                    if (j == key.Length - 1)
                    {
                        j = -1;
                    }
                }

                final.Add(result.ToString());
                result = new StringBuilder();
                forDecrypt = Console.ReadLine();
            }

            for (int i = 0; i < final.Count; i++)
            {
                int typeStart = final[i].IndexOf('&') + 1;
                int typeEnd = final[i].LastIndexOf('&');
                string type = final[i].Substring(typeStart, typeEnd - typeStart);

                int coordinatesStart = final[i].IndexOf('<') + 1;
                int cordinatesEnd = final[i].LastIndexOf('>');
                string cordinates = final[i].Substring(coordinatesStart, cordinatesEnd - coordinatesStart);
                Console.WriteLine($"Found {type} at {cordinates}");
            }
        }
    }
}
