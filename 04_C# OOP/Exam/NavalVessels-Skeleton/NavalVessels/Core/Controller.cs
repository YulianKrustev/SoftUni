using System;
using System.Collections.Generic;
using System.Text;
using NavalVessels.Repositories;
using NavalVessels.Models;
using NavalVessels.Models.Contracts;
using System.Linq;

namespace NavalVessels.Core
{
    public class Controller : Contracts.IController
    {
        private VesselRepository vessels;
        private ICollection<ICaptain> captains;

        public Controller()
        {
            vessels = new VesselRepository();
            captains = new List<ICaptain>();
        }

        public string AssignCaptain(string selectedCaptainName, string selectedVesselName)
        {
            if (captains.FirstOrDefault(x => x.FullName == selectedCaptainName) == null)
            {
                return $"Captain {selectedCaptainName} could not be found.";
            }

            var vessel = vessels.FindByName(selectedVesselName);

            if (vessel == null)
            {
                return $"Vessel {selectedVesselName} could not be found.";
            }

            if (vessel.Captain != null)
            {
                return $"Vessel {selectedVesselName} is already occupied.";
            }

            var captain = captains.FirstOrDefault(x => x.FullName == selectedCaptainName);

            vessel.Captain = captain;
            captain.AddVessel(vessel);

            return $"Captain {selectedCaptainName} command vessel {selectedVesselName}.";
        }

        public string AttackVessels(string attackingVesselName, string defendingVesselName)
        {
            var attackingVessel = vessels.FindByName(attackingVesselName);
            var defendingVessel = vessels.FindByName(defendingVesselName);

            if (attackingVessel == null || defendingVessel == null)
            {
                if (attackingVessel == null)
                {
                    return $"Vessel {attackingVesselName} could not be found.";
                }
                else
                {
                    return $"Vessel {defendingVessel} could not be found.";
                }
            }

            if (attackingVessel.ArmorThickness == 0 || defendingVessel.ArmorThickness == 0)
            {
                return $"Unarmored vessel {defendingVesselName} cannot attack or be attacked.";
            }

            attackingVessel.Attack(defendingVessel);
            attackingVessel.Captain.IncreaseCombatExperience();
            defendingVessel.Captain.IncreaseCombatExperience();

            return $"Vessel {defendingVesselName} was attacked by vessel {attackingVesselName} - current armor thickness: {defendingVessel.ArmorThickness}.";
        }

        public string CaptainReport(string captainFullName)
        {
            return captains.FirstOrDefault(x => x.FullName == captainFullName).Report();
        }

        public string HireCaptain(string fullName)
        {
            ICaptain captain = new Captain(fullName);
            if (captains.Contains(captain))
            {
                return $"Captain {fullName} is already hired.";
            }

            captains.Add(captain);
            return $"Captain {fullName} is hired.";
        }

        public string ProduceVessel(string name, string vesselType, double mainWeaponCaliber, double speed)
        {
            if (vessels.FindByName(name) != null)
            {
                return $"{vesselType} vessel {name} is already manufactured.";
            }
            else if (vesselType != "Battleship"  && vesselType != "Submarine")
            {
                return $"Invalid vessel type.";
            }

            Vessel vessel = null;

            if (vesselType == "Submarine")
            {
                vessel = new Submarine(name, mainWeaponCaliber, speed);
            }
            else
            {
                vessel = new Battleship(name, mainWeaponCaliber, speed);
            }

            vessels.Add(vessel);
            return $"{vesselType} {name} is manufactured with the main weapon caliber of {mainWeaponCaliber} inches and a maximum speed of {speed} knots.";
        }

        public string ServiceVessel(string vesselName)
        {
            var vesselToRapair = vessels.FindByName(vesselName);

            if (vesselToRapair != null)
            {
                vesselToRapair.RepairVessel();
                return $"Vessel {vesselName} was repaired.";
            }
            else
            {
                return $"Vessel {vesselName} could not be found.";
            }
        }

        public string ToggleSpecialMode(string vesselName)
        {
            var vessel = vessels.FindByName(vesselName);
            
            if (vessel == null)
            {
                return $"Vessel {vesselName} could not be found.";
            }

            if (vessel.GetType().Name == "Battleship")
            {
                Battleship battleshipVessel = (Battleship)vessel;
                battleshipVessel.ToggleSonarMode();
                return $"Battleship {vesselName} toggled sonar mode.";
            }
            else 
            {
                Submarine submarineVessel = (Submarine)vessel;
                submarineVessel.ToggleSubmergeMode();
                return $"Submarine {vesselName} toggled submerge mode.";
            }
        }

        public string VesselReport(string vesselName)
        {
            return vessels.FindByName(vesselName).ToString();
        }
    }
}
