using System;
using System.Collections.Generic;
using System.Linq;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine().Split();
            int numberOfDigits = int.Parse(tokens[0]);
            int numbersToPop = int.Parse(tokens[1]);
            int specialNumber = int.Parse(tokens[2]);

            int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Queue<int> digits = new Queue<int>(input);

            for (int i = 0; i < numbersToPop; i++)
            {
                digits.Dequeue();
            }

            if (digits.Contains(specialNumber))
            {
                Console.WriteLine("true");
            }
            else if (digits.Count < 1)
            {
                Console.WriteLine("0");
            }
            else
            {
                int smallest = int.MaxValue;
                int currentNumber = 0;

                while (digits.Count != 0)
                {
                    currentNumber = digits.Dequeue();

                    if (currentNumber < smallest)
                    {
                        smallest = currentNumber;
                    }
                }

                Console.WriteLine(smallest);
            }
        }
    }
}
