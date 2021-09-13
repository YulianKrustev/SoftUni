using MilitaryElite.Contracts;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(string id, string firstName, string lastName, decimal salary, Dictionary<string, IPrivate> privatesList) 
            : base(id, firstName, lastName, salary)
        {
            PrivatesList = privatesList;
        }

        public Dictionary<string, IPrivate> PrivatesList { get; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");

            foreach (var currentPrivate in PrivatesList)
            {
                sb.AppendLine("  " + currentPrivate.Value.ToString());
            }
            return sb.ToString().Trim();
        }
    }
}
