using Sales.Models.Entities;
using System.Collections.Generic;

namespace Sales.Models.Abstract
{
    public interface IProductRepository : IRepository<Product>
    {
        List<Product> GetPopularProducts();
    }
}
