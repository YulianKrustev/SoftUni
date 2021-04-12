using System;
using System.Collections.Generic;
using System.Linq;

namespace FastFood
{
    class Program
    {
        static void Main(string[] args)
        {
            int preparedFood = int.Parse(Console.ReadLine());
            int[] takedOrders = Console.ReadLine().Split().Select(int.Parse).ToArray();
            Queue<int> orders = new Queue<int>(takedOrders);
            int biggestOrder = 0;
            int ordersLeft = 0;
            bool notEnoughFood = false;

            Console.WriteLine(orders.Max());

            while (orders.Count > 0)
            {
                int currentOrder = orders.Dequeue();

                if (preparedFood - currentOrder >= 0)
                {
                    preparedFood -= currentOrder;
                }
                else
                {
                    notEnoughFood = true;
                    ordersLeft += currentOrder;
                }
            }

            if (notEnoughFood)
            {
                Console.WriteLine($"Orders left: {ordersLeft}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
