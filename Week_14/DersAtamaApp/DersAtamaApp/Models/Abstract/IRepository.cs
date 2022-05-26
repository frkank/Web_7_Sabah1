using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DersAtamaApp.Models.Abstract
{
    public interface IRepository<T> where T:class, new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T GetById(int id);
        List<T> GetAll();
        
    }
}
