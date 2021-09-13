using System;
using System.Collections.Generic;
using System.Linq;

namespace BirthdayCelebrations
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<IBirthdateable> citizens = new List<IBirthdateable>();

            while (input != "End")
            {
                string[] data = input.Split();

                if (data[0] == "Citizen")
                {
                    string name = data[1];
                    string age = data[2];
                    string id = data[3];
                    string birthDdate = data[4];

                    Citizen citizen = new Citizen(name, age, id, birthDdate);
                    citizens.Add(citizen);
                }
                else if (data[0] == "Pet")
                {
                    string name = data[1];
                    string birthDdate = data[2];

                    Pet pet = new Pet(name, birthDdate);
                    citizens.Add(pet);
                }

                input = Console.ReadLine();
            }

            string birthYear = Console.ReadLine();

            if (citizens.Any(x => x.BirthDate.EndsWith($"/{birthYear}")) == false)
            {
                Console.WriteLine("<empty output>");
                return;
            }

            foreach (IBirthdateable citizen in citizens)
            {
                if (citizen.BirthDate.EndsWith($"/{birthYear}"))
                {
                    Console.WriteLine(citizen.BirthDate);
                }
            }
        }
    }
}
