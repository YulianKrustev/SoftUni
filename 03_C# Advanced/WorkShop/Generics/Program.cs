using System;
using System.Collections.Generic;

namespace BoxOfT
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Box<int> list = new Box<int>();

            list.Add(4);
            list.Add(6);

            Console.WriteLine(list.Remove());

            Console.WriteLine(string.Join(" ", list.ToString()));
        }
    }
}
