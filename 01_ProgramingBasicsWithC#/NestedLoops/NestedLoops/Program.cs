using System;
using System.Threading;

namespace NestedLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int h = 0; h <= 23; h++)
            {
                for (int m = 0; m <= 59; m++)
                {
                    for (int s = 0; s <= 59; s++)
                    {
                        
                        Thread.Sleep(1000);
                        Console.WriteLine($"{h:d2}:{m:d2}:{s:d2}");
                        
                    }
                   
                }
            }
        }
    }
}
