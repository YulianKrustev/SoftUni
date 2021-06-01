using System;
using System.Linq;

namespace AppliedArithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command = Console.ReadLine().ToLower();
            Func<int, int> Add = x => x + 1;
            Func<int, int> Multiply = x => x * 2;
            Func<int, int> subtract = x => x - 1;
            Action<int[]> Print = x => Console.WriteLine(string.Join(" ", x));

            while(command != "end")
            {
                switch (command)
                {
                    case "add": numbers = numbers.Select(x => Add(x)).ToArray(); break;
                    case "multiply": numbers = numbers.Select(x => Multiply(x)).ToArray(); break;
                    case "subtract": numbers = numbers.Select(x => subtract(x)).ToArray(); break;
                    default: Print(numbers);
                        break;
                }

                command = Console.ReadLine();
            }
        }
    }
}
