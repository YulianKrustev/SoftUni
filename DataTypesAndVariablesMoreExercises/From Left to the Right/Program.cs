using System;

namespace From_Left_to_the_Right
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int minus = -1;
                bool isRightNum = false;
                string leftNum = string.Empty;
                string rightNum = string.Empty;
                long leftSum = 0;
                long rightSum = 0;
                string numAsString = Console.ReadLine();
                for (int j = 0; j < numAsString.Length; j++)
                {
                    if (numAsString[j] == '-')
                    {
                        minus = j;
                        continue;
                        
                    }
                    if (numAsString[j] == ' ')
                    {
                        isRightNum = true;
                        continue;
                    }
                    if (isRightNum == false)
                    {
                        leftNum += numAsString[j];
                    }
                    else
                    {
                        rightNum += numAsString[j];
                    }
                }
               
                long currentLeft = long.Parse(leftNum);
                long currentRight = long.Parse(rightNum);
                if (minus == 0)
                {
                    currentLeft *= -1;
                }
                else if (minus > 1)
                {
                    currentRight *= -1;
                }
                if (currentLeft > currentRight)
                {
                    for (int j = 0; j < leftNum.Length; j++)
                    {
                        leftSum += long.Parse(leftNum[j].ToString());
                    }
                    Console.WriteLine(leftSum);
                }
                else if (currentRight >= currentLeft)
                {
                    for (int k = 0; k < rightNum.Length; k++)
                    {
                        rightSum += long.Parse(rightNum[k].ToString());
                    }
                    Console.WriteLine(rightSum);
                }
            }
        }
    }
}
