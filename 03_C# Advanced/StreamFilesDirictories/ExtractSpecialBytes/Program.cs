using System;
using System.IO;

namespace ExtractSpecialBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bytes = File.ReadAllText("bytes.txt").Split();

            string[] png = File.ReadAllText("example.png").Split();

            Console.WriteLine(png[0]);

    
        }
    }
}
