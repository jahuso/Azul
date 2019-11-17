using Blue.DAL.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blue.DAL
{
    public class PatientRepository<T>: GenericRepository<Patient>, IPatientRepository<T> where T : class
    {
        private readonly BlueDBContext _dbContext;
        private readonly DbSet<T> _dbSet;
        public PatientRepository(BlueDBContext context) : base(context)
        {
            this._dbContext = context;
            this._dbSet = this._dbContext.Set<T>();
        }

        public Task Add(T entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public new async Task<T> GetbyId(int id)
        {
            //return this._dbSet.Find(id);
            return await this._dbContext.FindAsync<T>(id);
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await this._dbSet.ToListAsync<T>();
            //return await this._dbContext.Patient.ToListAsync<T>();
        }
    }
}
