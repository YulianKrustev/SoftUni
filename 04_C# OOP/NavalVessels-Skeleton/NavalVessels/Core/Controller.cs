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

            if (vessel.Captain.FullName != "default") 
            {
                return $"Vessel {selectedVesselName} is already occupied.";
            }

            ICaptain captain = new Captain(selectedCaptainName);

            vessel.Captain = captain;
            captain.AddVessel(vessel);

            return $"Captain {selectedCaptainName} command vessel {selectedVesselName}.";
        }

        public string AttackVessels(string attackingVesselName, string defendingVesselName)
        {
            throw new NotImplementedException();
        }

        public string CaptainReport(string captainFullName)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        public string ToggleSpecialMode(string vesselName)
        {
            throw new NotImplementedException();
        }

        public string VesselReport(string vesselName)
        {
            throw new NotImplementedException();
        }
    }
}
