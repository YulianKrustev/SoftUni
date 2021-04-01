using System;
using System.Collections.Generic;

namespace Orders
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, List<decimal>> orders = new Dictionary<string, List<decimal>>();

            while (input != "buy")
            {
                string[] order = input.Split();

                if (orders.ContainsKey(order[0]) == false)
                {
                    orders.Add(order[0], new List<decimal>() { 0, 0 });
                }

                orders[order[0]][0] = decimal.Parse(order[1]);
                orders[order[0]][1] += decimal.Parse(order[2]);

                input = Console.ReadLine();
            }

            foreach (var product in orders)
            {
                Console.WriteLine($"{product.Key} -> {product.Value[0] * product.Value[1]:f2}");
            }
        }
    }
}
