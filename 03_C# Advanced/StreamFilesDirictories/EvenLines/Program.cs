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
                        string revarse = $"{string.Join(" ", currentSplit.Reverse())}";
                        Console.WriteLine(revarse);
                    }
                }
            }
        }
    }
}
