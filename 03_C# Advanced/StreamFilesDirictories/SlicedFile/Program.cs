using System;
using System.IO;

namespace SlicedFile
{
    class Program
    {
        static void Main(string[] args)
        {
            int parts = int.Parse(Console.ReadLine());
            var length = new FileInfo("../../../ForSlice.txt").Length;
            var sizeOfPart = length / parts;
            int counter = 0;

            using(var sr = new StreamReader("../../../ForSlice.txt"))
            {
                while (sr.EndOfStream == false)
                {
                    counter++;

                    if (parts - counter > 0)
                    {
                        var buffer = new char[sizeOfPart];
                        sr.Read(buffer, 0, buffer.Length);

                        using (var sw = new StreamWriter($"Slice{counter}.txt"))
                        {
                            sw.Write(buffer);
                        }
                    }
                    else
                    {
                        using (var sw = new StreamWriter($"Slice{parts}.txt", true))
                        {
                            var buffer = new char[length - ((counter - 1) * sizeOfPart)];
                            sr.Read(buffer, 0, buffer.Length);
                            sw.Write(buffer);
                        }
                    }   
                }
            }
        }
    }
}
