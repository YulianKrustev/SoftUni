using System;
using System.Collections.Generic;
using System.Linq;

namespace Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] clothes = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Stack<int> box = new Stack<int>(clothes);
            int sizeOfRack = int.Parse(Console.ReadLine());
            int currentRack = 0;
            int counter = 1;

            while (box.Count > 0)
            {
                if (box.Peek() + currentRack <= sizeOfRack)
                {
                    currentRack += box.Pop();
                }
                else
                {
                    counter++;
                    currentRack = 0;
                }
            }

            Console.WriteLine(counter);
        }
    }
}
