using System;
using System.IO;

namespace Extract_file
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            string[] pathName = Path.GetFileName(path).Split('.');
            Console.WriteLine($"File name: {pathName[0]}");
            Console.WriteLine($"File extension: {pathName[1]}");
        }
    }
}
