using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int countOfCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < countOfCars; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];

                int speed = int.Parse(input[1]);
                int power = int.Parse(input[2]);
                Engine engine = new Engine(speed, power);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];
                cargo cargo = new cargo(cargoType, cargoWeight);

                List<Tire> tires = new List<Tire>();

                double tire1Pressure = double.Parse(input[5]);
                int tire1Age = int.Parse(input[6]);
                Tire tire1 = new Tire(tire1Age, tire1Pressure);
                tires.Add(tire1);

                double tire2Pressure = double.Parse(input[7]);
                int tire2Age = int.Parse(input[8]);
                Tire tire2 = new Tire(tire2Age, tire2Pressure);
                tires.Add(tire2);

                double tire3Pressure = double.Parse(input[9]);
                int tire3Age = int.Parse(input[10]);
                Tire tire3 = new Tire(tire3Age, tire3Pressure);
                tires.Add(tire3);

                double tire4Pressure = double.Parse(input[11]);
                int tire4Age = int.Parse(input[12]);
                Tire tire4 = new Tire(tire4Age, tire4Pressure);
                tires.Add(tire4);

                Car car = new Car(cargo, tires, engine, model);
                cars.Add(car);
            }

            string command = Console.ReadLine();

            if (command == "fragile")
            {
                foreach (Car car in cars.Where(x => x.Cargo.Type == "fragile").Where(x => x.Tires.Any(x => x.TirePressure < 1)))
                {
                    Console.WriteLine(car.Model);
                }
            }
            else
            {
                foreach (Car car in cars.Where(x => x.Cargo.Type == "flamable").Where(x => x.Engine.Power > 250))
                {
                    Console.WriteLine(car.Model);
                }
            }
        }
    }
}
