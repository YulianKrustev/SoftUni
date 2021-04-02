using System;
using System.Collections.Generic;
using System.Linq;

namespace SnowWhite
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, int> dwarfDataBase = new Dictionary<string, int>();

            while (input != "Once upon a time")
            {
                string[] data = input.Split(" <:> ");
                string name = data[0];
                string color = data[1];
                int physics = int.Parse(data[2]);
                string id = name + ":" + color;

                if (dwarfDataBase.ContainsKey(id) == false)
                {                  
                    dwarfDataBase.Add(id, physics);
                }
                else if (dwarfDataBase[id] < physics)
                {
                    dwarfDataBase[id] = physics;
                }

                input = Console.ReadLine();
            }

            foreach (var dwarf in dwarfDataBase.OrderByDescending(x => x.Value)
                .ThenByDescending(x => dwarfDataBase.Where(y => y.Key.Split(':')[1] == x.Key.Split(':')[1]).Count()))
            {
                Console.WriteLine($"({dwarf.Key.Split(':')[1]}) {dwarf.Key.Split(':')[0]} <-> {dwarf.Value}");
            }
        }
    }
}
