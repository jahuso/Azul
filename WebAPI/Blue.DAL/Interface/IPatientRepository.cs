using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blue.DAL.Interface
{
    public interface IPatientRepository<T> where T : class
    {
        Task<T> GetbyId(int id);
        Task<IEnumerable<T>> GetAll();
    }
}
