using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductShop
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            

            var databese = new Dictionary<string, Dictionary<string, double>>();

            while (input != "Revision")
            {
                string[] tokens = input.Split(", ");
                string store = tokens[0];
                string product = tokens[1];
                double price = double.Parse(tokens[2]);

                if (databese.ContainsKey(store) == false)
                {
                    databese.Add(store, new Dictionary<string, double>());
                }

                databese[store].Add(product, price);
                input = Console.ReadLine();
            }

            foreach (var store in databese.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{store.Key}->");

                foreach (var product in store.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
