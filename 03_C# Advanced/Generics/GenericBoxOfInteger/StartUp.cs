using System;

namespace GenericBoxOfInteger
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

            Console.WriteLine(list.ToString());
        }
    }
}
