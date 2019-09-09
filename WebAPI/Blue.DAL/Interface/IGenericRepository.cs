using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blue.DAL.Interface
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();
        T GetbyId(int id);
        Task Add(T entity);
        Task Update(T entity);
        void Delete(T entity);
        bool Exists(int Id);
    }
}
