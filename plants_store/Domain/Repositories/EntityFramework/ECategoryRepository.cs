using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using online_pharmacy.Domain.Entities;
using online_pharmacy.Domain.Repositories.Abstract;

namespace online_pharmacy.Domain.Repositories.EntityFramework
{
    public class ECategoryRepository: ICategoryRepository

    {
        
        private readonly DbContext context;

        public ECategoryRepository(DbContext context)
        {
            this.context = context;
        }

        IQueryable<Category> GetCategories()
        {
            return context.Categories;
        }

        Category GetCategoryById(Guid id)
        {
            return context.Categories.FirstOrDefault(x => x.Id == id);
        }

        void SaveCategory(Category category)
        {
            if (category.Id == default)
                context.Entry(category).State = EntityState.Added;
            else
                context.Entry(category).State = EntityState.Modified;
            context.SaveChanges();

        }

        void DeleteCategory(Guid id)
        {
            context.Categories.Remove(new Category() {Id = id});
        }

        IQueryable<Category> ICategoryRepository.GetCategories()
        {
            throw new NotImplementedException();
        }

        Category ICategoryRepository.GetCategoryById(Guid id)
        {
            throw new NotImplementedException();
        }

        void ICategoryRepository.SaveCategory(Category category)
        {
            throw new NotImplementedException();
        }

        void ICategoryRepository.DeleteCategory(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}
