using System;
using System.Linq;

namespace GenericSwapMethodIntegers
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> list = new Box<int>();
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                int current = int.Parse(Console.ReadLine());
                list.Add(current);
            }

            int[] indexes = Console.ReadLine().Split().Select(int.Parse).ToArray();

            list.Swap(indexes[0], indexes[1]);

            Console.WriteLine(list.ToString());
        }
    }
}
