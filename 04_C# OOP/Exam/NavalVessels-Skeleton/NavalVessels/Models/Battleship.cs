using System;

namespace NavalVessels.Models
{
    public class Battleship : Vessel, Contracts.IBattleship
    {
        private bool sonarMode;
        public Battleship(string name, double mainWeaponCaliber, double speed) : base(name, mainWeaponCaliber, speed, 300)
        {
            initialArmorThickness = 300;
        }
   
        public bool SonarMode { get => sonarMode; private set => sonarMode = value; }

        public void ToggleSonarMode()
        {
            if (sonarMode == false)
            {
                sonarMode = true;
                this.MainWeaponCaliber += 40;
                this.Speed -= 5;
            }
            else
            {
                sonarMode = false;
                this.MainWeaponCaliber -= 40;
                this.Speed += 5;
            }
        }

        public override string ToString()
        {
            string sonarModeText = this.SonarMode == true ? " *Sonar mode: ON" : " *Sonar mode: OFF";
            return base.ToString() + Environment.NewLine + sonarModeText;
        }
    }
}