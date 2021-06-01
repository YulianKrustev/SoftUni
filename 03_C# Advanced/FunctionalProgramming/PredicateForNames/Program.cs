using System;
using System.Linq;

namespace PredicateForNames
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthOfName = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();

            Func<string, bool> checkLengthFunc = x => x.Length <= lengthOfName;
            names.Where(checkLengthFunc).ToList().ForEach(x => Console.WriteLine(x));
        }
    }
}
