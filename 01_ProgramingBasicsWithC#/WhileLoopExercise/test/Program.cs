using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            double vacation = double.Parse(Console.ReadLine());
            double savedMoney = double.Parse(Console.ReadLine());
            int countDays = 0;
            int spendDays = 0;

            while (savedMoney >= vacation)
            {
                string saveOrSpend = Console.ReadLine();
                double currentSum = double.Parse(Console.ReadLine());
                countDays++;

                if (saveOrSpend == "save")
                {
                    savedMoney += currentSum;
                }
                else if (savedMoney < currentSum)
                {
                    savedMoney = 0;
                    spendDays++;
                }
                else
                {
                    savedMoney -= currentSum;
                    spendDays++;
                }


            }
            if (spendDays == 5)
            {
                Console.WriteLine($"You can't save the money.n/{spendDays}");
            }
            else if (savedMoney >= vacation)
            {
                Console.WriteLine($"You saved the money for {countDays} days.");
            }
        }
    }
}
