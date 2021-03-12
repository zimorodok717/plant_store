using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using online_pharmacy.Domain.Entities;

namespace online_pharmacy.Domain.Repositories.Abstract
{
  
    public interface IPlantRepository
    {
        IQueryable<Plant> GetPlants();
        Plant GetPlant (Guid id);

        void AddPlant(Medicine category);

        void DeletePlant(Guid id);
    }
}

