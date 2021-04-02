using System;

namespace Coins
{
    class Program
    {
        static void Main(string[] args)
        {
            double changeLeft = double.Parse(Console.ReadLine());
            changeLeft = changeLeft * 100;
            int countCoins = 0;
            

            while (changeLeft > 0)
            {
                if (changeLeft >= 200)
                {
                    changeLeft -= 200;
                    countCoins++;
                }
                else if (changeLeft >= 100)
                {
                    changeLeft -= 100;
                    countCoins++;
                }
                else if (changeLeft >= 50)
                {
                    changeLeft -= 50;
                    countCoins++;
                }
                else if (changeLeft >= 20)
                {
                    changeLeft -= 20;
                    countCoins++;
                }
                else if (changeLeft >= 10)
                {
                    changeLeft -= 10;
                    countCoins++;
                }
                else if (changeLeft >= 5)
                {
                    changeLeft -= 5;
                    countCoins++;
                }
                else if (changeLeft >= 2)
                {
                    changeLeft -= 2;
                    countCoins++;
                }
                else if (changeLeft >= 1)
                {
                    changeLeft -= 1;
                    countCoins++;
                }

            }
            Console.WriteLine(countCoins);
        }
    }
}
