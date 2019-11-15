using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using PoolSaison2019.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoolSaison2019.Data
{
    public class PoolSaison2019Repository<T> : IRepository<T> where T : Entity
    {
        private readonly IServiceScopeFactory scopeFactory;
        public async Task<IQueryable<T>> GetAll()
        {
            using (var scope = scopeFactory.CreateScope())
            {
                var dbContext = scope.ServiceProvider.GetRequiredService<PoolSaison2019Context>();
                var items = await DbContext.Set<T>().ToListAsync();
                return items.AsQueryable();
            }
        }
    }
}
