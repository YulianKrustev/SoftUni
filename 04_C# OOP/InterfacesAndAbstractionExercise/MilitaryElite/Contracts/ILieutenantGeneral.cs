using System.Collections.Generic;

namespace MilitaryElite.Contracts
{
    public interface ILieutenantGeneral : IPrivate
    {
        public Dictionary<string, IPrivate> PrivatesList { get; }
    }
}