using System;
using System.Collections.Generic;
using System.Text;
using MilitaryElite.Contracts.Enums;

namespace MilitaryElite.Contracts
{
    public interface ISpecialisedSoldier : IPrivate
    {
        public Corps Corps { get; }
    }
}
