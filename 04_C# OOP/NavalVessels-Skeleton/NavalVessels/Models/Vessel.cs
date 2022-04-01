using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace NavalVessels.Models
{
    public class Vessel : Contracts.IVessel
    {
        private string name;
        public string Name
        {
            get => name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException("Vessel name cannot be null or empty.");
                }

                name = value;
            }
        }

        public ICaptain Captain { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public double ArmorThickness { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double MainWeaponCaliber => throw new NotImplementedException();

        public double Speed => throw new NotImplementedException();

        public ICollection<string> Targets => throw new NotImplementedException();

        public void Attack(IVessel target)
        {
            throw new NotImplementedException();
        }

        public void RepairVessel()
        {
            throw new NotImplementedException();
        }
    }
}
