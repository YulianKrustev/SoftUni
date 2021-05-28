using System;
using System.IO.Compression;

namespace ZipAndExtract
{
    class Program
    {
        static void Main(string[] args)
        {
            string startPath = @"d:\softuni";
            string zipPath = @"d:\softuni.zip";
            string extractPath = @"d:\softuniE";

            ZipFile.CreateFromDirectory(startPath, zipPath);

            ZipFile.ExtractToDirectory(zipPath, extractPath);
        }
    }
}
