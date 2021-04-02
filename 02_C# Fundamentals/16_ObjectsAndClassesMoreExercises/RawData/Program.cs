using System;
using System.Collections.Generic;
using System.Linq;

namespace RawData
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();
            int counter = 0;

            for (int i = 0; i < numberOfCars; i++)
            {
                string[] input = Console.ReadLine().Split();
                Engine engine = new Engine(int.Parse(input[1]), int.Parse(input[2]));
                Cargo cargo = new Cargo(int.Parse(input[3]), input[4]);
                Car car = new Car(input[0], engine, cargo, counter);
                cars.Add(car);
                counter++;
            }

            string command = Console.ReadLine();
            List<Car> final = new List<Car>();

            if (command == "fragile")
            {
                final = cars.FindAll(x => x.Cargo.CargoType == "fragile" && x.Cargo.CargoWeight < 1000);
            }
            else
            {
                final = cars.FindAll(x => x.Cargo.CargoType == "flamable" && x.Engine.EnginePower > 250);
            }

            final = final.OrderBy(x => x.Counter).ToList();
            Console.WriteLine(string.Join(Environment.NewLine, final));

        }
    }

    class Car
    {
        public Car(string model, Engine engine, Cargo cargo, int counter)
        {
            Model = model;
            Engine = engine;
            Cargo = cargo;
            Counter = Counter;
        }
        public string Model { get; set; }
        public Engine Engine { get; set; }
        public Cargo Cargo { get; set; }
        public int Counter { get; set; }

        public override string ToString()
        {
            return $"{Model}";
        }

    }

    class Engine
    {
        public Engine(int engineSpeed, int enginePower)
        {
            EngineSpeed = engineSpeed;
            EnginePower = enginePower;
        }
        public int EngineSpeed { get; set; }
        public int EnginePower { get; set; }
    }

    class Cargo
    {
        public Cargo(int cargoWeight, string type)
        {
            CargoWeight = cargoWeight;
            CargoType = type;
        }
        public int CargoWeight { get; set; }
        public string CargoType { get; set; }
    }
}
