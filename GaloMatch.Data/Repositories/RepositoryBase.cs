using GaloMatch.Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace GaloMatch.Data.Repositories
{
    public class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        protected readonly DataBaseContext Db;

        public RepositoryBase(DataBaseContext context)
        {
            Db = context;
        }

        public async Task<T> CreateAsync(T entity)
        {
            await Db.Set<T>().AddAsync(entity);
            await Db.SaveChangesAsync();
            return await Task.FromResult(entity);
        }

        public async Task<ICollection<T>> CreateAsync(ICollection<T> entities)
        {
            await Db.Set<T>().AddRangeAsync(entities);
            await Db.SaveChangesAsync();
            return await Task.FromResult(entities);
        }

        public async Task<bool> UpdateAsync(T entity)
        {
            Db.Set<T>().UpdateRange(entity);
            return await Db.SaveChangesAsync() > 0;
        }

        public async Task<bool> UpdateAsync(ICollection<T> entities)
        {
            Db.Set<T>().UpdateRange(entities);
            return await Db.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveAsync(T entity)
        {
            
                Db.Set<T>().Remove(entity);
            
            return await Db.SaveChangesAsync() > 0;
        }

        public async Task<bool> RemoveAsync(ICollection<T> entities)
        {
           
               
                Db.Set<T>().RemoveRange(entities);
            
            return await Db.SaveChangesAsync() > 0;
        }

        public async Task<T> GetByIdAsync(Guid id) => await Db.Set<T>().FindAsync(id);

        public async Task<List<T>> ListAsync()
        {
            var query = await Db.Set<T>().ToListAsync();
            return query ?? new List<T>();
        }

    }
}
