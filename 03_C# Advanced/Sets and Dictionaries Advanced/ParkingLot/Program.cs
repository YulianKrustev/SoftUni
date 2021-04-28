using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            HashSet<string> database = new HashSet<string>();

            while (input != "END")
            {
                string[] tokens = input.Split(", ");
                string command = tokens[0];
                string carNumber = tokens[1];

                switch (command)
                {
                    case "IN": database.Add(carNumber); break;
                    case "OUT": database.Remove(carNumber); break;
                }

                input = Console.ReadLine();
            }

            if (database.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in database)
                {
                    Console.WriteLine(car);
                }
            }
            
        }
    }
}
