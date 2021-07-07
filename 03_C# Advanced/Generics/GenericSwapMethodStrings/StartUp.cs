using System;
using System.Linq;

namespace GenericSwapMethodStrings
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<string> list = new Box<string>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                string current = Console.ReadLine();
                list.Add(current);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            list.Swap(indexes[0], indexes[1]);

            Console.WriteLine(list.ToString());
        }
    }
}
