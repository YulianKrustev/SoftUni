using System;
using System.Collections.Generic;
using System.Linq;

namespace Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string nameOfCustomer = Console.ReadLine();
            Queue<string> queue = new Queue<string>();

            while (nameOfCustomer != "End")
            {
                if (nameOfCustomer == "Paid")
                {
                    while (queue.Any())
                    {
                        Console.WriteLine(string.Join(Environment.NewLine, queue.Dequeue()));
                    }
                }
                else
                {
                    queue.Enqueue(nameOfCustomer);
                }

                nameOfCustomer = Console.ReadLine();
            }

            Console.WriteLine($"{queue.Count} people remaining.");
        }
    }
}
