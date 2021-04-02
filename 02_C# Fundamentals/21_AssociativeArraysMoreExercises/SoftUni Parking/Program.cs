using System;
using System.Collections.Generic;

namespace SoftUni_Parking
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfVisitiers = int.Parse(Console.ReadLine());
            Dictionary<string, string> cars = new Dictionary<string, string>();

            for (int i = 0; i < numberOfVisitiers; i++)
            {
                string[] data = Console.ReadLine().Split();
                string command = data[0].ToLower();

                switch (command)
                {
                    case "register":
                        string name = data[1];
                        string licensePlateNumber = data[2];

                        if (cars.ContainsKey(name))
                        {
                            Console.WriteLine($"ERROR: already registered with plate number {cars[name]}");
                        }
                        else
                        {
                            cars.Add(name, licensePlateNumber);
                            Console.WriteLine($"{name} registered {cars[name]} successfully");
                        }
                        break;

                    case "unregister":
                        string user = data[1];

                        if (cars.ContainsKey(user))
                        {
                            Console.WriteLine($"{user} unregistered successfully");
                            cars.Remove(user);
                        }
                        else
                        {
                            Console.WriteLine($"ERROR: user {user} not found");
                        }
                        break;
                }
            }

            foreach (var user in cars)
            {
                Console.WriteLine($"{user.Key} => {user.Value}");
            }
        }
    }
}
