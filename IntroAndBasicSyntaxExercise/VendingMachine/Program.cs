using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string insertCoin = Console.ReadLine();
            double totalSum = 0;

            while (insertCoin != "Start")
            {
                double currentCoin = double.Parse(insertCoin);
                if ((currentCoin == 0.1) || (currentCoin == 0.2) || (currentCoin == 0.5) || (currentCoin == 1) || (currentCoin == 2))
                {
                    totalSum += currentCoin;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currentCoin}");
                }
                insertCoin = Console.ReadLine();
            }

            string productName = Console.ReadLine();

            while (productName != "End")
            {
                if ((productName == "Nuts") || (productName == "Water") || (productName == "Crisps") || (productName == "Soda") || (productName == "Coke"))
                {
                    if (productName == "Nuts")
                    {
                        totalSum -= 2.0;
                        if (totalSum < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            totalSum += 2.0;
                        }
                        else
                        {
                            Console.WriteLine("Purchased nuts");
                        }
                    }
                    else if (productName == "Water")
                    {
                        totalSum -= 0.7;
                        if (totalSum < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            totalSum += 0.7;
                        }
                        else
                        {
                            Console.WriteLine("Purchased water");
                        }
                    }
                    else if (productName == "Crisps")
                    {
                        totalSum -= 1.5;
                        if (totalSum < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            totalSum += 1.5;
                        }
                        else
                        {
                            Console.WriteLine("Purchased crisps");
                        }
                    }
                    else if (productName == "Soda")
                    {
                        totalSum -= 0.8;
                        if (totalSum < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            totalSum += 0.8;
                        }
                        else
                        {
                            Console.WriteLine("Purchased soda");
                        }
                    }
                    else if (productName == "Coke")
                    {
                        totalSum -= 1.0;
                        if (totalSum < 0)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            totalSum += 1.0;
                        }
                        else
                        {
                            Console.WriteLine("Purchased coke");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }
                productName = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalSum:f2}");
        }
    }
}
