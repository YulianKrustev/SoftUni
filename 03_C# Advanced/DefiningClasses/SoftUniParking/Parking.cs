using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;
        private int count;

        public int Count
        {
            get { return cars.Count; }
        }


        public Parking(int count)
        {
            Capacity = count;
            Cars = new List<Car>();
        }
        public List<Car> Cars
        {
            get { return cars; }
            set { cars = value; }
        }

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public string AddCar(Car car)
        {
            if (cars.Any(x => x.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }
            else if (cars.Count == capacity)
            {
                return "Parking is full!";
            }
            else
            {
                cars.Add(car);
                return $"Successfully added new car {car.Make} {car.RegistrationNumber}";
            }
        }

        public string RemoveCar(string registrationNumber)
        {
            if (cars.Any(x => x.RegistrationNumber == registrationNumber))
            {
                cars.Remove(cars.Find(x => x.RegistrationNumber == registrationNumber));
                return $"Successfully removed {registrationNumber}";
            }

            return "Car with that registration number, doesn't exist!";
        }

        public Car GetCar(string registrationNumber)
        {
            return cars.FirstOrDefault(x => x.RegistrationNumber == registrationNumber);
        }

        public void RemoveSetOfRegistrationNumber(List<string> registrationNumbers)
        {
            foreach (var number in registrationNumbers)
            {
                cars.Remove(cars.FirstOrDefault(x => x.RegistrationNumber == number));
            }
        }
    }
}
