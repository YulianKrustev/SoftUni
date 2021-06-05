using System;
using System.Collections.Generic;
using System.Linq;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = int.Parse(Console.ReadLine());
            List<string> names = Console.ReadLine().Split().ToList();

            Func<string, int, bool> lengthCheck = (name, sum) => name.Sum(x => x) >= sum;

            Console.WriteLine(names.FirstOrDefault(x => lengthCheck(x, sum)));
        }
    }
}
