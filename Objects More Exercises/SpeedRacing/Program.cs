using System;
using System.Collections.Generic;


namespace SpeedRacing
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Car> cars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                Car car = new Car(Console.ReadLine().Split());
                cars.Add(car);
            }

            string command = Console.ReadLine();

            while (command.ToLower() != "end")
            {
                string[] data = command.Split();
                int index = cars.FindIndex(x => x.Model == data[1]);
                bool isPosible = cars[index].Drive(double.Parse(data[2]));

                if (!isPosible)
                {
                    Console.WriteLine("Insufficient fuel for the drive");
                }
                command = Console.ReadLine();
            }

            Console.WriteLine(string.Join(Environment.NewLine, cars));
        }
    }

    class Car
    {
        public Car(string[] info)
        {
            Model = info[0];
            FuelAmount = double.Parse(info[1]);
            FuelConsumation = double.Parse(info[2]);
            TraveledDistance = 0;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumation { get; set; }
        public double TraveledDistance { get; set; }

        public bool Drive(double data)
        {
            double neededFuel = data * FuelConsumation;

            if (FuelAmount >= neededFuel)
            {
                FuelAmount -= neededFuel;
                TraveledDistance += data;
                return true;
            }
                return false;
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:f2} {TraveledDistance}";
        }

    }
}
