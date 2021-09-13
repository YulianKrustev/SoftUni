using MilitaryElite.Contracts;
using MilitaryElite.Contracts.Enums;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class Engineer : SpecialisedSoldier, IEngineer
    {
        public Engineer(string id, string firstName, string lastName, decimal salary, Corps corps, ICollection<IRepair> repairs) 
            : base(id, firstName, lastName, salary, corps)
        {
            Repairs = repairs;
        }
        public ICollection<IRepair> Repairs { get ; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Repairs:");

            foreach (var currentRepair in Repairs)
            {
                sb.AppendLine("  " + currentRepair.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
