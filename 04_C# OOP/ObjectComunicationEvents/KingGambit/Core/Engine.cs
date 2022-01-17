using KingGambit.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KingGambit.Core
{
    public class Engine
    {
        public void Run()
        {
            King king = new King(Console.ReadLine());
            List<Person> people = new List<Person>();

            string[] royalGardsNames = Console.ReadLine().Split();
            string[] footmensNames = Console.ReadLine().Split();

            foreach (var royalGardName in royalGardsNames)
            {
                RoyalGuard royalGuard = new RoyalGuard(royalGardName);
                people.Add(royalGuard);
                king.KingUnderAttack += royalGuard.KingIsUnderAttack;
            }

            foreach (var footManName in footmensNames)
            {
                Footman footman = new Footman(footManName);
                people.Add(footman);
                king.KingUnderAttack += footman.KingIsUnderAttack;
            }

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End") break;

                var commandArgs = input.Split();
                var command = commandArgs[0];

                switch (command)
                {
                    case "Kill":
                        var soldierName = commandArgs[1];
                        var soldier = people.FirstOrDefault(s => s.Name == soldierName);
                        king.KingUnderAttack -= soldier.KingIsUnderAttack;
                        people.Remove(soldier);
                        break;
                    case "Attack":
                        king.KingIsUnderAttack(this, EventArgs.Empty);
                        break;
                    default: break;
                }
            }
        }
    }
}
