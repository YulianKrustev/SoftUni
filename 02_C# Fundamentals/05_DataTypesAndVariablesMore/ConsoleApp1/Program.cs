using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                bool isRightNum = false;
                string leftNum = string.Empty;
                string rightNum = string.Empty;
                string numAsText = Console.ReadLine();
                for (int j = 0; j < numAsText.Length; j++)
                {
                    if (numAsText[j] == ' ')
                    {
                        isRightNum = true;
                        continue;
                    }
                    if (isRightNum == false)
                    {
                        leftNum += numAsText[j];
                    }
                    else
                    {
                        rightNum += numAsText[j];
                    }                   
                }
                long currentLeft = long.Parse(leftNum);
                long currentRight = long.Parse(rightNum);

                if (currentLeft >= currentRight)
                {
                    long leftSum = 0;
                    while (Math.Abs(currentLeft) > 0)
                    {
                        leftSum += currentLeft % 10;
                        currentLeft /= 10;
                    }
                    Console.WriteLine(Math.Abs(leftSum));
                }
                else
                {
                    long rightSum = 0;
                    while (Math.Abs(currentRight) > 0)
                    {
                        rightSum += currentRight % 10;
                        currentRight /= 10;
                    }
                    Console.WriteLine(Math.Abs(rightSum));
                }
            }
        }
    }
}
