using Sales.Models.Entities;
using System.Collections.Generic;

namespace Sales.Models.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        List<Category> GetPopularCategories();
    }
}
