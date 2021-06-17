using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Engine> engines = new List<Engine>();

            int countOfEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfEngines; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                int power = int.Parse(input[1]);
                string efficiency;
                string displacement;

                if (input.Length == 3 && char.IsDigit(input[2], 0))
                {
                    displacement = input[2];
                    efficiency = "n/a";
                }
                else if (input.Length == 3)
                {
                    efficiency = input[2];
                    displacement = "n/a";
                }
                else if (input.Length == 4)
                {
                    displacement = input[2];
                    efficiency = input[3];
                }
                else
                {
                    displacement = "n/a";
                    efficiency = "n/a";
                }

                Engine engine = new Engine(model, power, displacement, efficiency);
                engines.Add(engine);
            }

            int countOfCars = int.Parse(Console.ReadLine());

            List<Car> cars = new List<Car>();

            for (int i = 0; i < countOfCars; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                string model = input[0];
                Engine engine = engines.Find(x => x.Model == input[1]);
                string weight;
                string color;

                if (input.Length == 3 && char.IsDigit(input[2], 0))
                {
                    weight = input[2];
                    color = "n/a";
                }
                else if (input.Length == 3)
                {
                    color = input[2];
                    weight = "n/a";
                }
                else if (input.Length == 4)
                {
                    weight = input[2];
                    color = input[3];
                }
                else
                {
                    weight = "n/a";
                    color = "n/a";
                }

                Car car = new Car(model, engine, weight, color);
                cars.Add(car);
            }

            foreach (Car car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
}
