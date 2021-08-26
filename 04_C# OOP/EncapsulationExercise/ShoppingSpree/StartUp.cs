using System;
using System.Collections.Generic;
using System.Linq;

namespace ShoppingSpree
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] people = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            string[] products = Console.ReadLine().Split(";", StringSplitOptions.RemoveEmptyEntries);
            List<Product> listOfProducts = new List<Product>();
            List<Person> listOfPeople = new List<Person>();

            for (int i = 0; i < people.Length; i++)
            {
                try
                {
                    string[] current = people[i].Split("=");

                    string name = current[0];
                    decimal money = decimal.Parse(current[1]);

                    Person person = new Person(name, money);

                    listOfPeople.Add(person);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }

            }

            for (int i = 0; i < products.Length; i++)
            {
                try
                {
                    string[] current = products[i].Split("=");

                    string name = current[0];
                    decimal cost = decimal.Parse(current[1]);

                    Product product = new Product(name, cost);

                    listOfProducts.Add(product);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return;
                }

            }

            string input = Console.ReadLine();

            while (input != "END")
            {
                string[] current = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string nameOfPerson = current[0];
                string nameOfProduct = current[1];

                int index = listOfPeople.FindIndex(x => x.Name == nameOfPerson);
                Product product = listOfProducts.Find(x => x.Name == nameOfProduct);

                listOfPeople[index].Add(product);

                input = Console.ReadLine();
            }

            foreach (Person person in listOfPeople)
            {
                if (person.Bag.Count > 0)
                {
                    Console.WriteLine($"{person.Name} - {string.Join(", ", person.Bag.Select(x => x.Name))}");
                }
                else
                {
                    Console.WriteLine($"{person.Name} - Nothing bought");
                }
            }
        }
    }
}

