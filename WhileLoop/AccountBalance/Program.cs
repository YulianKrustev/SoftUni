using System;

namespace AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            string currentSum = Console.ReadLine();
            double accountBalance = 0;

            while (currentSum != "NoMoreMoney")
            {
                double money = double.Parse(currentSum);

                if (money < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                accountBalance += money;
                Console.WriteLine($"Increase: {money:f2}");
                currentSum = Console.ReadLine();
            }
            Console.WriteLine($"Total: {accountBalance:f2}");
        }
    }
}
