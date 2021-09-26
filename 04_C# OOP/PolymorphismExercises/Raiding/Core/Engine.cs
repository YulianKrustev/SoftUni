using Raiding.Heroes;
using System;
using System.Collections.Generic;

namespace Raiding.Core
{
    public class Engine
    {
        public void Run()
        {
            IList<BaseHero> heroesList = new List<BaseHero>();

            int numberOfHeroes = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfHeroes; i++)
            {
                string name = Console.ReadLine();
                string typeOfHero = Console.ReadLine();

                switch (typeOfHero)
                {
                    case "Druid":
                        Druid druid = new Druid(name);
                        heroesList.Add(druid);
                        break;
                    case "Paladin":
                        Paladin paladin = new Paladin(name);
                        heroesList.Add(paladin);
                        break;
                    case "Rogue":
                        Rogue rouge = new Rogue(name);
                        heroesList.Add(rouge);
                        break;
                    case "Warrior":
                        Warrior warrior = new Warrior(name);
                        heroesList.Add(warrior);
                        break;
                    
                    default:
                        Console.WriteLine("Invalid hero!");
                        i--;
                        break;
                }
            }

            int enemyBossEnergy = int.Parse(Console.ReadLine());

            int damage = 0;

            foreach (BaseHero currentHero in heroesList)
            {
                Console.WriteLine(currentHero.CastAbility());
                damage += currentHero.Power;
            }

            if (enemyBossEnergy > damage)
            {
                Console.WriteLine("Defeat...");
            }

            else
            {
                Console.WriteLine("Victory!");
            }
        }
    }
}