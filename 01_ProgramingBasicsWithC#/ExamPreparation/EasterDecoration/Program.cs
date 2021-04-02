using System;

namespace EasterDecoration
{
    class Program
    {
        static void Main(string[] args)
        {
            int clients = int.Parse(Console.ReadLine());
            double totalIncome = 0;

            for (int i = 0; i < clients; i++)
            {
                string purchase = Console.ReadLine();
                double clientBill = 0;
                int numOfPurchases = 0;
                while (purchase != "Finish")
                {
                    numOfPurchases++;
                    switch (purchase)
                    {
                        case "basket":
                            clientBill += 1.5;
                            break;
                        case "wreath":
                            clientBill += 3.8;
                            break;
                        case "chocolate bunny":
                            clientBill += 7;
                            break;
                    }
                    purchase = Console.ReadLine();
                }
                if (numOfPurchases % 2 == 0)
                {
                    clientBill = 0.8 * clientBill;
                }
                Console.WriteLine($"You purchased {numOfPurchases} items for {clientBill:f2} leva.");
                totalIncome += clientBill;
            }
            Console.WriteLine($"Average bill per client is: {totalIncome / clients:f2} leva.");
        }
    }
}
