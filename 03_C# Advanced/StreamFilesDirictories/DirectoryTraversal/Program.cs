using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace DirectoryTraversal
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo files = new DirectoryInfo(Environment.CurrentDirectory);
            var list = files.GetFiles();
            Dictionary<string, SortedDictionary<string, long>> fullList = new Dictionary<string, SortedDictionary<string, long>>();

            foreach (var file in list)
            {
                string currentName = file.Name;
                string currentExtension = file.Extension;
                long currenLength = file.Length;

                if (fullList.ContainsKey(currentExtension) == false)
                {
                    fullList.Add(currentExtension, new SortedDictionary<string, long>());
                }

                fullList[currentExtension].Add(currentName, currenLength);

            }

            foreach (var item in fullList.OrderByDescending(x => x.Value.Count))
            {
                using (StreamWriter sw = new StreamWriter("../../../report.txt", true))
                {
                    sw.WriteLine($"{item.Key}");

                    foreach (var file in item.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                    {
                        sw.WriteLine($"--{file.Key} - {file.Value / 1000.0} kb.");
                    }
                }
            }
        }
    }
}
