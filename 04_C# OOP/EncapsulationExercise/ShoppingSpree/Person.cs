using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ShoppingSpree
{
    public class Person
    {
        private string name;
        private decimal money;
        private List<Product> bag;

        public Person(string name, decimal money)
        {
            Money = money;
            Name = name;
            bag = new List<Product>();
        }

        public IReadOnlyList<Product> Bag => this.bag.AsReadOnly();

        public decimal Money
        {
            get { return money; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Money cannot be negative");
                }
                money = value; 
            }
        }

        public string Name
        {
            get { return name; }
            set 
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Name cannot be empty");
                }
                name = value; 
            }
        }

        public void Add(Product product)
        {
            if (this.money >= product.Cost)
            {
                this.money -= product.Cost;
                bag.Add(product);
                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
            else
            {
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            }         
        }
    }
}
