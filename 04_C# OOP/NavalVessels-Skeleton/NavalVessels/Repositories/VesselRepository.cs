using NavalVessels.Models.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace NavalVessels.Repositories
{
    public class VesselRepository : Contracts.IRepository<Models.Contracts.IVessel>
    {
        private List<IVessel> models = new List<IVessel>();
        public IReadOnlyCollection<IVessel> Models => models.AsReadOnly();

        public void Add(IVessel model)
        {
            this.models.Add(model);
        }

        public IVessel FindByName(string name)
        {
            return models.FirstOrDefault(x => x.Name == name);
        }

        public bool Remove(IVessel model)
        {
            if (models.Contains(model) && model != null)
            {
                models.Remove(model);
                return true;
            }
            return false;
        }
    }
}
