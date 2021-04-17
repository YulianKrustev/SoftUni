using System;
using System.Collections.Generic;

namespace HotPatato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();
            Queue<string> queue = new Queue<string>(input);
            int n = int.Parse(Console.ReadLine());
            int counter = 0;

            while (queue.Count != 1)
            {
                counter++;
                string current = queue.Peek();

                if (counter % n == 0)
                {
                    Console.WriteLine($"Removed {queue.Dequeue()}");
                }
                else
                {
                    queue.Dequeue();
                    queue.Enqueue(current);
                }
            }

            Console.WriteLine($"Last is {queue.Dequeue()}");
        }
    }
}
