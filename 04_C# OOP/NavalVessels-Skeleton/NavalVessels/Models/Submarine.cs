using System;

namespace NavalVessels.Models
{
    public class Submarine : Vessel, Contracts.ISubmarine
    {
        private bool submergeMode;
        public Submarine(string name, double mainWeaponCaliber, double speed) : base(name, mainWeaponCaliber, speed, 200)
        {
            this.initialArmorThickness = 200;
        }

        public bool SubmergeMode { get => submergeMode; private set => submergeMode = value; }

        public void ToggleSubmergeMode()
        {
            if (submergeMode == false)
            {
                submergeMode = true;
                this.MainWeaponCaliber += 40;
                this.Speed -= 4;
            }
            else
            {
                submergeMode = false;
                this.MainWeaponCaliber -= 40;
                this.Speed += 4;
            }
        }

        public override string ToString()
        {
            string sumergeModeInfo = submergeMode == true ? "ON" : "OFF";
            return base.ToString() + Environment.NewLine + sumergeModeInfo;
        }
    }
}