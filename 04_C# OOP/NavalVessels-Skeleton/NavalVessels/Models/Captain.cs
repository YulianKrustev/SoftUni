using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavalVessels.Models
{
    public class Captain : Contracts.ICaptain
    {
        private string fullName;
        private int initialCombarExperience;
        private ICollection<IVessel> vessels;

        public Captain(string fullName)
        {
            FullName = fullName;
            vessels = new List<IVessel>();
            initialCombarExperience = 0;
        }

        public string FullName
        {
            get => fullName;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Captain full name cannot be null or empty string.");
                }
                fullName = value;
            }
        }

        public int CombatExperience { get => initialCombarExperience; private set => initialCombarExperience = value; }

        public ICollection<IVessel> Vessels => vessels;

        public void AddVessel(IVessel vessel)
        {
            if (vessel == null)
            {
                throw new NullReferenceException("Null vessel cannot be added to the captain.");
            }
            this.vessels.Add(vessel);
        }

        public void IncreaseCombatExperience()
        {
            this.initialCombarExperience += 10;
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.FullName} has {this.initialCombarExperience} combat experience and commands {vessels.Count} vessels.");

            if (vessels.Count > 0)
            {
                foreach (var vessel in vessels)
                {
                    sb.AppendLine(vessel.ToString());
                }               
            }

            return sb.ToString().Trim();
        }
    }
}
