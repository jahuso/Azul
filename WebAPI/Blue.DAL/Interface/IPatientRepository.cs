using Blue.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Blue.DAL.Interface
{
    public interface IPatientRepository : IGenericRepository<Patient>
    {
        Task<Patient> GetbyId(string id);
        bool Exists(int Id);
    }
}
