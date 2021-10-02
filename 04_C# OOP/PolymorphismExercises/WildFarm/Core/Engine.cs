using System;
using System.Collections.Generic;
using WildFarm.Animals;
using WildFarm.Food;

namespace WildFarm.Core
{
    public class Engine
    {
        public void Run()
        {
            IList<Animal> animals = new List<Animal>();
            Dictionary<string, string[]> animalsFavoriteFood = new Dictionary<string, string[]>
            {
                { "1", new string[]{ "Vegetable", "Fruit", "Meat", "Seeds" } },

            };

            string input = Console.ReadLine();

            while (input != "End")
            {
                string[] animalData = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Animal currentAnimal = CreateAnimal(animalData);
                animals.Add(currentAnimal);

                string[] foodData = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Foods foods = CreateFood(foodData);

                Console.WriteLine(currentAnimal.ProducingSound());
                currentAnimal.FeedIt(foods);

                input = Console.ReadLine();
            }

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.ToString());
            }
        }

        private Foods CreateFood(string[] foodData)
        {
            string foodType = foodData[0];
            int quantity = int.Parse(foodData[1]);
            Foods foods = null;

            if (foodType == "Fruit")
            {
                foods = new Fruit(quantity);
            }
            else if (foodType == "Meat")
            {
                foods = new Meat(quantity);
            }
            else if (foodType == "Seeds")
            {
                foods = new Seeds(quantity);
            }
            else if (foodType == "Vegetable")
            {
                foods = new Vegetable(quantity);
            }

            return foods;
        }

        private Animal CreateAnimal(string[] animalData)
        {
            Animal currentAnimal = null;
            string typeOfAnimal = animalData[0];
            string name = animalData[1];
            double weight = double.Parse(animalData[2]);

            if (typeOfAnimal == "Cat" || typeOfAnimal == "Tiger")
            {
                string livingRegion = animalData[3];
                string breed = animalData[4];

                if (typeOfAnimal == "Cat")
                {
                    currentAnimal = new Cat(name, weight, livingRegion, breed);
                }
                else
                {
                    currentAnimal = new Tiger(name, weight, livingRegion, breed);
                }
            }
            else if (typeOfAnimal == "Owl" || typeOfAnimal == "Hen")
            {
                double wingSize = double.Parse(animalData[3]);

                if (typeOfAnimal == "Owl")
                {
                    currentAnimal = new Owl(name, weight, wingSize);
                }
                else
                {
                    currentAnimal = new Hen(name, weight, wingSize);
                }
            }
            else if (typeOfAnimal == "Mouse" || typeOfAnimal == "Dog")
            {
                string livingRegion = animalData[3];

                if (typeOfAnimal == "Mouse")
                {
                    currentAnimal = new Mouse(name, weight, livingRegion);
                }
                else
                {
                    currentAnimal = new Dog(name, weight, livingRegion);
                }
            }

            return currentAnimal;
        }
    }
}
