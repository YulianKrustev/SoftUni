using System;
using System.Collections.Generic;
using System.Linq;

namespace Shopping_Spree
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] peopleInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] productsInfo = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Person> people = new List<Person>();
            List<Product> products = new List<Product>();
            string command = Console.ReadLine();

            for (int i = 0; i < peopleInfo.Length; i++)
            {
                string[] info = peopleInfo[i].Split("=");
                string name = info[0];
                decimal moeny = decimal.Parse(info[1]);
                Person person = new Person(name, moeny);
                people.Add(person);

            }

            for (int i = 0; i < productsInfo.Length; i++)
            {
                string[] info = productsInfo[i].Split("=");
                string name = info[0];
                decimal cost = decimal.Parse(info[1]);
                Product product = new Product(name, cost);
                products.Add(product);
            }

            while (command.ToLower() != "end")
            {
                string[] task = command.Split();
                decimal personMoney = people.Where(x => x.Name == task[0]).Select(x => x.Money).First();
                decimal productCost = products.Where(x => x.Name == task[1]).Select(x => x.Cost).FirstOrDefault();
                int indexOfPerson = people.FindIndex(x => x.Name == task[0]);
                int indexOfProduct = products.FindIndex(x => x.Name == task[1]);

                if (productCost <= personMoney)
                {
                    people[indexOfPerson].BagOfProducts.Add(products[indexOfProduct]);
                    Console.WriteLine($"{people[indexOfPerson].Name} bought {products[indexOfProduct].Name}");
                    people[indexOfPerson].Money -= products[indexOfProduct].Cost;
                }
                else
                {
                    Console.WriteLine($"{people[indexOfPerson].Name} can't afford {products[indexOfProduct].Name}");
                }
                command = Console.ReadLine();

            }

            for (int i = 0; i < people.Count; i++)
            {
                if (people[i].BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{people[i].Name} - Nothing bought");
                }
                else
                {
                    Console.WriteLine($"{people[i].Name} - {string.Join(", ", people[i].BagOfProducts.Select(x => x.Name).ToList())}");
                }
                
            }
        }
    }

    class Person
    {
        public Person(string name, decimal money)
        {
            Name = name;
            Money = money;
        }
        public string Name { get; set; }
        public decimal Money { get; set; }

        public List<Product> BagOfProducts { get; set; } = new List<Product>();
    }

    class Product
    {
        public Product(string name, decimal cost)
        {
            Name = name;
            Cost = cost;
        }
        public string Name { get; set; }
        public decimal Cost { get; set; }
    }
}
