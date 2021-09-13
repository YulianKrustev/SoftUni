

namespace MilitaryElite.Models
{
    using MilitaryElite.Contracts;
    using MilitaryElite.Contracts.Enums;

    public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
    {
        protected SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, Corps corps) 
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public Corps Corps { get; }
    }
}
