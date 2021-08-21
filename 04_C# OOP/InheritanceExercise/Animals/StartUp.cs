using System;
using System.Collections.Generic;

namespace Animals
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            string input = Console.ReadLine();

            while (input != "Beast!")
            {
                string[] tokens = Console.ReadLine()
                                        .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string name = tokens[0];
                int age = int.Parse(tokens[1]);
                string gender;

                try
                {
                    if (input == "Cat")
                    {
                        gender = tokens[2];
                        Cat cat = new Cat(name, age, gender);
                        animals.Add(cat);
                    }
                    else if (input == "Dog")
                    {
                        gender = tokens[2];
                        Dog dog = new Dog(name, age, gender);
                        animals.Add(dog);
                    }
                    else if (input == "Frog")
                    {
                        gender = tokens[2];
                        Frog frog = new Frog(name, age, gender);
                        animals.Add(frog);
                    }
                    else if (input == "Kitten")
                    {
                        Kitten kit = new Kitten(name, age);
                        animals.Add(kit);
                    }
                    else if (input == "Tomcat")
                    {
                        Tomcat tom = new Tomcat(name, age);
                        animals.Add(tom);
                    }
                    else
                    {
                        throw new ArgumentException("Invalid input!");
                    }
                }
                catch (Exception ex)
                {

                    Console.WriteLine(ex.Message); 
                }
                

                input = Console.ReadLine();
            }

            animals.ForEach(Console.WriteLine);
        }
    }
}
