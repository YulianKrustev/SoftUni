using System;
using System.IO;

namespace MergeTextFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputFileOne = "input1.txt";
            string inputFileTwo = "input2.txt";

            MetgeText(inputFileOne, inputFileTwo);
        }

        private static void MetgeText(string inputFileOne, string inputFileTwo)
        {
            using (StreamReader sr1 = new StreamReader(inputFileOne))
            {
                using (StreamReader sr2 = new StreamReader(inputFileTwo))
                {
                    while (sr1.EndOfStream == false || sr2.EndOfStream == false)
                    {
                        using (StreamWriter sr = new StreamWriter("output.txt", true))
                        {
                            if (sr1.EndOfStream == false)
                            {
                                string current1 = sr1.ReadLine();
                                sr.WriteLine(current1);
                            }
                            if (sr2.EndOfStream == false)
                            {
                                string current2 = sr2.ReadLine();
                                sr.WriteLine(current2);
                            }
                        }
                    }
                }
            }
        }
    }
}
