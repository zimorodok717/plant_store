using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using online_pharmacy.Domain.Entities;

namespace online_pharmacy.Domain.Repositories.Abstract
{
    public interface ICategoryRepository
    {
        IQueryable<Category> GetCategories();
        Category GetCategoryById(Guid id);

        void SaveCategory(Category category);

        void DeleteCategory(Guid id);
    }
}
