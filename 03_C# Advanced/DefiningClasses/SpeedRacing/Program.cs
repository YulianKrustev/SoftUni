using System;
using System.Collections.Generic;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int countOfCars = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < countOfCars; i++)
            {
                string[] input = Console.ReadLine().Split();
                string model = input[0];
                double fuelAmount = double.Parse(input[1]);
                double consumptionPerKm = double.Parse(input[2]);

                Car car = new Car(model, fuelAmount, consumptionPerKm);

                cars.Add(car);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] drive = command.Split();
                string model = drive[1];
                double distance = double.Parse(drive[2]);

                cars.Find(x => x.model == model).Drive(distance);

                command = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine($"{car.model} {car.fuelAmount:f2} {car.distance}");
            }
        }
    }
}
