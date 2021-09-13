using MilitaryElite.Contracts;

namespace MilitaryElite.Models
{
    public class Repair : IRepair
    {
        public Repair(string partName, int hoursWorkd)
        {
            PartName = partName;
            HoursWorkd = hoursWorkd;
        }

        public string PartName { get; }

        public int HoursWorkd { get; }

        public override string ToString()
        {
            return $"Part Name: {PartName} Hours Worked: {HoursWorkd}";
        }
    }
}
