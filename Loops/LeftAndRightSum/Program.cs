using System;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNumber = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
           
            for (int i = 0; i < inputNumber; i++)
            {
                leftSum = leftSum + (int.Parse(Console.ReadLine()));
            }
            for (int i = inputNumber; i < (inputNumber * 2); i++)
            {
                rightSum = rightSum + (int.Parse(Console.ReadLine()));
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = " + leftSum);
            }   else
            {
                Console.WriteLine("No, diff = " + Math.Abs(leftSum - rightSum));
            }
        }
    }
}
