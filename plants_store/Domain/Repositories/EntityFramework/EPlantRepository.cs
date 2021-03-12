using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using online_pharmacy.Domain.Entities;
using online_pharmacy.Domain.Repositories.Abstract;

namespace online_pharmacy.Domain.Repositories.EntityFramework
{
   public class EPlantRepository: IPlantRepository
    {
        private readonly DbContext context;

        public EPlantRepository(DbContext context)
        {
            this.context = context;
        }

       public IQueryable<Plant> GetPlants()
        {
            return context. Plants;
        }

        Plant GetPlant (Guid id)
        {
            return context.Plants.FirstOrDefault(x => x.Id == id);
        }

        void SavePlant (Plant plant)
        {
            if (plant.Id == default)
                context.Entry(plant).State = EntityState.Added;
            else
                context.Entry(plant).State = EntityState.Modified;
            context.SaveChanges();

        }

        void DeletePlant (Guid id)
        {
            context.Plants.Remove(new Plant () { Id = id });
        }

        Plant IPlantRepository.GetMedicine(Guid id)
        {
            throw new NotImplementedException();
        }

        void IPlantRepository.SavePlant (Plant plant)
        {
            throw new NotImplementedException();
        }

        void IPlantRepository.DeletePlant (Guid id)
        {
            throw new NotImplementedException();
        }
    }
}


