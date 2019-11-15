using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolSaison2019.Data
{
    public interface IRepository<T> where T : Entity
    {
        Task<IQueryable<T>> GetAll();
        
    }
}
