using System;
using System.IO;

namespace LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using(StreamReader sr = new StreamReader(@"../../../text.txt"))
            {
                int counter = 0;

                while (sr.EndOfStream ==false)
                {
                    string current = sr.ReadLine();
                    int letters = 0;
                    int puncruationMarks = 0;
                    counter++;

                    for (int i = 0; i < current.Length; i++)
                    {
                        if (char.IsLetter(current[i]))
                        {
                            letters++;
                        }
                        else if (current[i] != ' ')
                        {
                            puncruationMarks++;
                        }
                    }

                    using (StreamWriter sw = new StreamWriter("output.txt", true))
                    {
                        sw.WriteLine($"Line {counter}: {current} ({letters})({puncruationMarks})");
                    }
                }
            }
        }
    }
}
