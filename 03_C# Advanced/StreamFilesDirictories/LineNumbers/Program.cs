using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFile = "input.txt";
            string output = "output.txt";

            RerightFilesWithNumbers(inputFile, output);
        }

        private static void RerightFilesWithNumbers(string inputFile, string output)
        {
            using (StreamReader sr = new StreamReader(inputFile))
            {
                using (StreamWriter sw = new StreamWriter(output))
                {
                    int count = 1;

                    while (sr.EndOfStream == false)
                    {
                        string current = sr.ReadLine();
                        sw.WriteLine($"{count}. {current}");
                        count++;
                    }
                }
            }
        }
    }
}
