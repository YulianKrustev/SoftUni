using MilitaryElite.Contracts;
using MilitaryElite.Contracts.Enums;
using MilitaryElite.Models;
using System;
using System.Collections.Generic;

namespace MilitaryElite.Core
{
    class CommandInterpreter : ICommandInterpreter
    {
        private Dictionary<string, ISoldier> soldiers;

        public CommandInterpreter()
        {
            this.soldiers = new Dictionary<string, ISoldier>();
        }

        public string Read(string[] args)
        {
            string soldierType = args[0];
            string id = args[1];
            string firstName = args[2];
            string lastName = args[3];

            ISoldier soldier = null;

            if (soldierType == "Private")
            {
                decimal salary = decimal.Parse(args[4]);

                soldier = new Private(id, firstName, lastName, salary);

            }
            else if (soldierType == "LieutenantGeneral")
            {
                decimal salary = decimal.Parse(args[4]);
                var privets = new Dictionary<string, IPrivate>();

                for (int i = 5; i < args.Length; i++)
                {
                    string soldierId = args[i];
                    var currentSoldier = (IPrivate)soldiers[soldierId];
                    privets.Add(soldierId, currentSoldier);
                }

                soldier = new LieutenantGeneral(id, firstName, lastName, salary, privets);
            }
            else if (soldierType == "Engineer")
            {
                decimal salary = decimal.Parse(args[4]);
                bool isValidCorp = Enum.TryParse<Corps>(args[5], out Corps corps);

                if (isValidCorp == false)
                {
                    throw new Exception();
                }

                ICollection<IRepair> repairs = new List<IRepair>();

                for(int i = 6; i < args.Length; i+=2)
                {
                    string currentName = args[i];
                    int currentHours = int.Parse(args[i+1]);

                    IRepair repair = new Repair(currentName, currentHours);
                    repairs.Add(repair);

                }
                soldier = new Engineer(id, firstName, lastName, salary, corps, repairs);
            }
            else if (soldierType == "Commando")
            {
                decimal salary = decimal.Parse(args[4]);

                bool isValidCorp = Enum.TryParse<Corps>(args[5], out Corps corps);

                if (isValidCorp == false)
                {
                    throw new Exception();
                }               

                ICollection<IMission> missions = new List<IMission>();

                for (int i = 6; i < args.Length; i += 2)
                {
                    string missionName = args[i];
                    string missionState = args[i + 1];

                    bool isValidMission = Enum.TryParse<State>(missionState, out State stateREsult);

                    if (isValidMission == false)
                    {
                        continue;
                    }

                    IMission mission = new Mission(missionName, stateREsult);
                    missions.Add(mission);

                }
                soldier = new Commando(id, firstName, lastName, salary,corps, missions);
            }
            else if (soldierType == "Spy")
            {
                int codeNumber = int.Parse(args[4]);
                soldier = new Spy(id, firstName, lastName, codeNumber);
            }

            soldiers.Add(id, soldier);
            return soldier.ToString();
        }
    }
}
