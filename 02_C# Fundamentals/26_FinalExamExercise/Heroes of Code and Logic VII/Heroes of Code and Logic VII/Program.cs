using System;
using System.Collections.Generic;
using System.Linq;

namespace Heroes_of_Code_and_Logic_VII
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfHeroes = int.Parse(Console.ReadLine());
            Dictionary<string, Dictionary<string, int>> heroesList = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string[] currentHeroes = Console.ReadLine().Split();
                string name = currentHeroes[0];
                int hp = int.Parse(currentHeroes[1]);
                int mp = int.Parse(currentHeroes[2]);

                heroesList.Add(name, new Dictionary<string, int>());
                heroesList[name].Add("hp", hp);
                heroesList[name].Add("mp", mp);
            }

            string command = Console.ReadLine();

            while (command != "End")
            {
                string[] tokens = command.Split(" - ");
                string name = tokens[1];
                string action = tokens[0];

                if (action == "CastSpell")
                {
                    int mpNeeded = int.Parse(tokens[2]);
                    string spellName = tokens[3];

                    if (heroesList[name]["mp"] >= mpNeeded)
                    {
                        heroesList[name]["mp"] -= mpNeeded;
                        Console.WriteLine($"{name} has successfully cast {spellName} and now has {heroesList[name]["mp"]} MP!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} does not have enough MP to cast {spellName}!");
                    }
                }
                else if (action == "TakeDamage")
                {
                    int damage = int.Parse(tokens[2]);
                    string attacker = tokens[3];

                    if (heroesList[name]["hp"] > damage)
                    {
                        heroesList[name]["hp"] -= damage;
                        Console.WriteLine($"{name} was hit for {damage} HP by {attacker} and now has {heroesList[name]["hp"]} HP left!");
                    }
                    else
                    {
                        Console.WriteLine($"{name} has been killed by {attacker}!");
                        heroesList.Remove(name);
                    }
                }
                else if (action == "Recharge")
                {
                    int mp = int.Parse(tokens[2]);
                    int currentMp = heroesList[name]["mp"];

                    if (heroesList[name]["mp"] + mp > 200)
                    {
                        heroesList[name]["mp"] = 200;
                    }
                    else
                    {
                        heroesList[name]["mp"] += mp;
                    }

                    Console.WriteLine($"{name} recharged for {heroesList[name]["mp"] - currentMp} MP!");
                }
                else if (action == "Heal")
                {
                    int hp = int.Parse(tokens[2]);
                    int currenthp = heroesList[name]["hp"];

                    if (heroesList[name]["hp"] + hp > 100)
                    {
                        heroesList[name]["hp"] = 100;
                    }
                    else
                    {
                        heroesList[name]["hp"] += hp;
                    }

                    Console.WriteLine($"{name} healed for {heroesList[name]["hp"] - currenthp} HP!");
                }

                command = Console.ReadLine();
            }

            foreach (var heroe in heroesList.OrderByDescending(x => x.Value["hp"]).ThenBy(x=> x.Key))
            {
                Console.WriteLine(heroe.Key);
                Console.WriteLine($"HP: {heroe.Value["hp"]}");
                Console.WriteLine($"MP: {heroe.Value["mp"]}");
            }
        }
    }
}
