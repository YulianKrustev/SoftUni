using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int startNumber = int.Parse(Console.ReadLine());
            int endNumber = int.Parse(Console.ReadLine());
            int magicNumber = int.Parse(Console.ReadLine());
            int combinationsCounter = 0;
            bool flag = false;

            for (int i = startNumber; i <= endNumber; i++)
            {
                for (int j = startNumber; j <= endNumber; j++)
                {
                    combinationsCounter++;
                    if (i+j == magicNumber)
                    {
                        flag = true;
                        Console.WriteLine($"Combination N:{combinationsCounter} ({i} + {j} = {magicNumber})");
                        break;
                    }
                }
                if (flag == true)
                {
                    break;
                }
            }
            if (flag != true)
            {
                Console.WriteLine($"{combinationsCounter} combinations - neither equals {magicNumber}");
            }
        }
    }
}
