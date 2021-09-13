using System;
using System.Collections.Generic;
using System.Linq;

namespace FoodShortage
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int countOfBuyers = int.Parse(Console.ReadLine());
            List<IBuyer> buyersList = new List<IBuyer>();

            for (int i = 0; i < countOfBuyers; i++)
            {
                string[] data = Console.ReadLine().Split();
                string name;
                string age;
                string id;
                string birthdate;
                string group;

                if (data.Length == 4)
                {
                    name = data[0];
                    age = data[1];
                    id = data[2];
                    birthdate = data[3];

                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    buyersList.Add(citizen);
                }
                else
                {
                    name = data[0];
                    age = data[1];
                    group = data[2];

                    Rabel rabel = new Rabel(name, age, group);
                    buyersList.Add(rabel);
                }
            }

            string nameOfBuyer = Console.ReadLine();

            while (nameOfBuyer != "End")
            {
                if (buyersList.Any(x => x.Name == nameOfBuyer))
                {
                    buyersList.FirstOrDefault(n => n.Name == nameOfBuyer).BuyFood();
                }
               
                     nameOfBuyer = Console.ReadLine();
            }

            Console.WriteLine(buyersList.Sum(x => x.Food));
        }
    }
}
