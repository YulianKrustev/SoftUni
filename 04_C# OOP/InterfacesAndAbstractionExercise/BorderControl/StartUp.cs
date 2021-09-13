using System;
using System.Collections.Generic;

namespace BorderControl
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            List<IIdentifiable> citizens = new List<IIdentifiable>();

            while (input != "End")
            {
                string[] data = input.Split();

                if (data.Length == 2)
                {
                    string model = data[0];
                    string id = data[1];

                    Robot robot = new Robot(model, id);
                    citizens.Add(robot);
                }
                else
                {
                    string name = data[0];
                    string age = data[1];
                    string id = data[2];

                    Citizen citizen = new Citizen(name, age, id);
                    citizens.Add(citizen);
                }

                input = Console.ReadLine();
            }

            string fakeId = Console.ReadLine();

            foreach (IIdentifiable citizen in citizens)
            {
                if (citizen.Id.EndsWith(fakeId))
                {
                    Console.WriteLine(citizen.Id);
                }
            }
        }
    }
}
