using System;
using System.IO;

namespace CopyDirectoryContent
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = Console.ReadLine();
            string destinationPath = Console.ReadLine();
            CopyDirectoryContent(sourcePath, destinationPath);
        }

        private static void CopyDirectoryContent(string source, string destination)
        {
            foreach (string dirPath in Directory.GetDirectories(source, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(source, destination));
            }

            foreach (string newPath in Directory.GetFiles(source, "*.*", SearchOption.AllDirectories))
            {
                File.Copy(newPath, newPath.Replace(source, destination), true);
            }
        }
    }
}
