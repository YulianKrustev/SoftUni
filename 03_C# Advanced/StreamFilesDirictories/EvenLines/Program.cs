using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            List<StringBuilder> text = new List<StringBuilder>();
            int counter = 0;

            using (StreamReader sr = new StreamReader(@"../../../text.txt"))
            {
                string current = string.Empty;

                while (sr.EndOfStream == false)
                {
                    counter++;
                    current = sr.ReadLine();

                    if (counter % 2 != 0)
                    {
                        current = current.Replace('-', '@').Replace('.', '@').Replace(',', '@').Replace('!', '@').Replace('?', '@');
                        string[] currentSplit = current.Split();

                        StringBuilder revarse = new StringBuilder();

                        for (int i = currentSplit.Length - 1; i >= 0; i--)
                        {
                            revarse.Append(currentSplit[i] + " ");
                        }
                        text.Add(revarse);
                    }
                }
            }

            foreach (var item in text)
            {
                Console.WriteLine(item);
            }
        }
    }
}
