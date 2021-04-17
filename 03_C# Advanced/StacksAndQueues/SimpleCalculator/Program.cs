using System;
using System.Collections.Generic;
using System.Linq;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            Stack<int> stack = new Stack<int>();
            stack.Push(int.Parse(input[0]));

            for (int i = 1; i < input.Length; i += 2)
            {
                switch (input[i])
                {
                    case "+":
                        stack.Push(stack.Peek() + int.Parse(input[i + 1]));
                        break;
                    case "-":
                        stack.Push(stack.Peek() - int.Parse(input[i + 1]));
                        break;
                }
            }

            Console.WriteLine(stack.Peek());
        }
    }
}
