using Blue.DAL.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebAPI.Models;

namespace Blue.DAL
{
    public class GenericRepository<T>: IGenericRepository<T> where T:class
    {
        private readonly BlueDBContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepository(BlueDBContext context)
        {
            this._dbContext =context;
            this._dbSet = this._dbContext.Set<T>();
        }

        public async Task Add(T entity)
        {
            await this._dbSet.AddAsync(entity);
            await this._dbContext.SaveChangesAsync();
        }

        public void Delete(T entity)
        {
            this._dbSet.Remove(entity);
            this._dbContext.SaveChanges();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this._dbSet.ToListAsync();
        }

        public T GetbyId(int id)
        {
            return this._dbSet.Find(id);
        }

        public Task Update(T entity)
        {
            this._dbSet.Attach(entity);
            this._dbContext.Entry(entity).State = EntityState.Modified;
            return this._dbContext.SaveChangesAsync();
        }

        public bool Exists(int id)
        {
            return _dbContext.Doctor.Any(e => e.Code == id);
        }
    }
}
