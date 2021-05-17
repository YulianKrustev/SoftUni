using System;
using System.IO;

namespace ExtractSpecialBytes
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] bytes = File.ReadAllText("bytes.txt").Split();
            Console.WriteLine(bytes[0]);

    
        }
    }
}
